using prjFluxoCaixa.Classes.ClassesDoLivroCaixa;

namespace prjFluxoCaixa
{
    public partial class frmLivroCaixa : Form
    {
        static private Caixa ?caixa;

        static private List<Familia> familias = new List<Familia>(); // Lista criada com P nenhuma

        static private Responsavel[] res = {
                                            new Responsavel("H�lio Rangel", 'A'),
                                            new Responsavel("Maria Aparecida", 'A'),
                                            new Responsavel("Carlos",'U'),
                                            new Responsavel("Jos� Am�rico",'U')
                                           };

        public frmLivroCaixa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //Metodo pra inicializar o Form (programa)
        {
            if (caixa == null) // Primeira vez que roda o APP
            {
                caixa = Serializa.load();
                if (caixa == null) // Foi l� ler o arquivo e ainda n�o existe
                {
                    caixa = new Caixa("Outubro/23"); // Instancia o caixa que n�o existia
                    Serializa.save(caixa); // salva o caixa recem criado (agora vai ter)
                }
                txRelatorio.Text = caixa.relatorio();
            }
            if(familias.Count == 0)
            {
                familias.Add(new Familia("Cr�dito", "CRE"));
                familias.Add(new Familia("Cart�rio", "CAR"));
                familias.Add(new Familia("Material escrit�rio", "ESC"));
                familias.Add(new Familia("Refei��o", "REF"));
                familias.Add(new Familia("Lanche", "LAN"));
                familias.Add(new Familia("TAXI", "TAX"));
                familias.Add(new Familia("Aplicativo", "APL"));
                familias.Add(new Familia("Manuten��o", "MAN"));
                familias.Add(new Familia("�nibus", "BUS"));
            }

            familias.Sort(); //S� posso usar pq tem o IComparable


            cbResponsavel.Items.Clear(); // Limpando o combo
            cbFamilia.Items.Clear();

            foreach (Familia f in familias)
            {
                cbFamilia.Items.Add(f.Nome);
            }

            foreach (Responsavel r in res)
            {
                cbResponsavel.Items.Add(r.Nome);
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DateTime data;

            if (!DateTime.TryParse(txData.Text, out data))
            {
                MessageBox.Show("Data digitada deve ser uma data v�lida!");
                txData.Focus();
                return;
            }

            if (data.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("Data futura � inv�lida!");
                txData.Focus();
                return;
            }

            if (txDescricao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Descri��o do lan�amento � obrigat�ria!");
                txDescricao.Focus();
                return;
            }

            if (cbResponsavel.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o respons�vel");
                cbResponsavel.Focus();
                return;
            }
            if (cbFamilia.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a fam�lia de lan�amento");
                cbFamilia.Focus();
                return;
            }


            if (!rbCredito.Checked && !rbDebito.Checked)
            {
                MessageBox.Show("Selecione se cr�dito ou d�bito!");
                return;
            }

            float valor;

            if (!float.TryParse(txValor.Text, out valor) || valor <= 0)
            {
                MessageBox.Show("Valor digitado n�o � um valor v�lido!");
                return;
            }


            if (caixa != null && rbDebito.Checked && caixa.saldo() < valor)
            {
                MessageBox.Show("Valor digitado maior que o saldo; Saldo: " + caixa.saldo());
                return;
            }

            String ?textoSelecionadoNoCombo = cbResponsavel.SelectedItem.ToString();
            Responsavel txtSel = null; // selec � o responsavel selecionado
            foreach(Responsavel responsavelNaLista in res)
            {
               if (textoSelecionadoNoCombo == responsavelNaLista.Nome)
                {
                    txtSel = responsavelNaLista;
                    break;
                }
            }
            if (txtSel == null)
            {
                MessageBox.Show("Erro inesperado. Respons�vel n�o cadastrado!");
                return;
            }

            String? familiaSelecionada = cbFamilia.SelectedItem.ToString();
            Familia? famSel = null;
            foreach (Familia familiaNaLista in familias)
            {
                if (familiaSelecionada == familiaNaLista.Nome)
                {
                    famSel = familiaNaLista;
                    break;
                }
            }
            if (famSel == null)
            {
                MessageBox.Show("Erro inesperado. Familia n�o cadastrada!");
                return;
            }

            Lancamento l = new Lancamento(
                data, 
                txDescricao.Text, 
                rbCredito.Checked ? 'C':'D',
                txtSel, 
                valor,
                famSel);

            if (caixa != null)
            {
                caixa.Add(l);
                Serializa.save(caixa);
                txRelatorio.Text = caixa.relatorio();
            }
            //Apaga as caixas de op��o
            txData.Text = null;
            txDescricao.Text = null;
            cbResponsavel.SelectedIndex = -1;
            cbFamilia.SelectedIndex = -1;
            rbCredito.Checked = false;
            rbDebito.Checked = false;
            txValor.Text = null;
            //
        }
    }
}