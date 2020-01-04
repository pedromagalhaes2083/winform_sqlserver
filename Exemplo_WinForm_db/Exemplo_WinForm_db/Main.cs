using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Exemplo_WinForm_db
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txt_Escola.Text))
            {
                return false;
            } 
            else if (string.IsNullOrWhiteSpace(txt_Matricula.Text))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txt_Nome.Text))
            {
                return false;
            }
            else
                return true;
        }
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if(Validar() == true)
            {
                // cria um modelo para ser usado pela dto
                DTO_Aluno aluno_modelo = new DTO_Aluno();
                aluno_modelo.str_Nome = txt_Nome.Text;
                aluno_modelo.dec_Matriula = Convert.ToDecimal(txt_Matricula.Text);
                aluno_modelo.str_Nome_Escola = txt_Escola.Text;

                //Insere no banco usando a bll
                Aluno aluno1 = new Aluno();
                aluno1.FpuInsert(aluno_modelo);
            }
            else
                MessageBox.Show("Erro campo não prenchido");
            
        }

        private void NomearGrid()
        {
            dgv_Aluno.Columns[0].HeaderText = "Matricula";
            dgv_Aluno.Columns[1].HeaderText = "Nome";
            dgv_Aluno.Columns[2].HeaderText = "Escola";
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {

                dgv_Aluno.DataSource = SqlChamadas.RetornarTable();
                NomearGrid();
                dgv_Aluno.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_Aluno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.InnerException + " " + ex.Message);
            }
        }
    }
}
