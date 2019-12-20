using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class ModifInventaire : Form
    {
        string stockPerso = "http://10.176.131.106:8080/api/Stock/StockPerso";
        private int idPerso;
        private JArray jsonModifInv = new JArray();
        private DataGridViewRow rowClone;
        
        public ModifInventaire(int idPerso)
        {
            InitializeComponent();
            rowClone = (DataGridViewRow)listJdtg.Rows[0].Clone();
            this.idPerso = idPerso;
            refreshDtg();
            
        }

        private void AddRowToDgv(string nom, string attribut)
        {
            DataGridViewRow row = (DataGridViewRow)rowClone.Clone();
            row.Cells[0].Value = nom;
            row.Cells[1].Value = attribut;
            listJdtg.Rows.Add(row);
        }

        public void refreshDtg()
        {
            listJdtg.Text = "";
            Task.Run(() =>
            {
                Task<string> result = Requetes.GetInfo(stockPerso + "?idPerso=" + idPerso.ToString());
                JArray jsonStock = JArray.Parse(result.Result);
                if (jsonStock.Count > 0)
                    foreach (JObject json in jsonStock)
                    {
                        AddRowToDgv(json["NOM_OBJET"].ToString(), json["ATTRIBUT"].ToString());
                    }
            });
        }

        private void listJdtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
