using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorMemoriaDinamica
{
    public partial class MainScreen : Form
    {
        int processos = 0;
        int indexRow = 0;
        int memo1, memo2, memo3, memo1Aloc = 0, memo2Aloc = 0, memo3Aloc = 0, storage, storageAloc = 0;
        string command = "";
        int[] alocacao = new int[3];

        public MainScreen()
        {
            InitializeComponent();
            memo1 = p_memo1.Maximum;
            memo2 = p_memo2.Maximum;
            memo3 = p_memo3.Maximum;
            storage = p_armazenamento.Maximum;
        }

        private void t_comandos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && t_comandos.Text!=null)
            {
                command = t_comandos.Lines[t_comandos.Lines.Length - 1];
                string parameters = command.Substring(command.IndexOf("(") + 1).TrimEnd(')');
                string[] parameter = parameters.Split(',');
                int metodo = checar_metodo();

                if (command.Contains("new("))
                {
                    switch (metodo)
                    {
                        case 0:
                            bestFitMethod(parameter[0], Convert.ToInt32(parameter[1]));
                            break;
                        case 1:
                            worstFitMethod(parameter[0], Convert.ToInt32(parameter[1]));
                            break;
                        case 2:
                            firstFitMethod(parameter[0], Convert.ToInt32(parameter[1]));
                            break;
                        case 3:
                            swappingMethod(parameter[0], Convert.ToInt32(parameter[1]));
                            break;
                    }

                }
                else if (command.Contains("kill("))
                {
                    killProcess(Convert.ToInt32(parameter[0]));
                }
                else if (command.Contains("run("))
                {
                    runProcess(Convert.ToInt32(parameter[0]));
                }
                else
                {
                    MessageBox.Show("O Comando digitado não é reconhecido pelo terminal", "Erro:", MessageBoxButtons.OK);
                    t_comandos.Clear();
                }

                p_memoria.Value = memo1Aloc + memo2Aloc + memo3Aloc;
                l_memo1Aloc.Text = "[ " + memo1Aloc + "Kb / 8Kb ]";
                l_memo2Aloc.Text = "[ " + memo2Aloc + "Kb / 16Kb ]";
                l_memo3Aloc.Text = "[ " + memo3Aloc + "Kb / 24Kb ]";
                l_memoAloc.Text = "[ " + p_memoria.Value + "Kb / 48Kb ]";
                l_storageAloc.Text = "[ " + p_armazenamento.Value + "Kb / 48Kb ]";
            }
        }
        public int checar_metodo()
        {
            int metodo = 0;
            if (rb_best_fit.Checked) { metodo = 0; };
            if (rb_worst_fit.Checked) { metodo = 1; };
            if (rb_first_fit.Checked) { metodo = 2; };
            if (rb_swapping.Checked) { metodo = 3; };
            return metodo;
        }
        public List<int> numerosPositivos(int[] numeros)
        {
            var numerosPositivos = new List<int>();
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] >= 0)
                {
                    numerosPositivos.Add(numeros[i]);
                }
            }
            return numerosPositivos;
        }

        private void bestFitMethod(string nomeProcesso, int memoProcesso)
        {
            processos++;
            alocacao[0] = (memo1 - memo1Aloc - memoProcesso);
            alocacao[1] = (memo2 - memo2Aloc - memoProcesso);
            alocacao[2] = (memo3 - memo3Aloc - memoProcesso);
            try
            {
                int index = Array.IndexOf(alocacao, numerosPositivos(alocacao).Min());

                switch (index)
                {
                    case 0:
                        memo1Aloc = memo1Aloc + memoProcesso;
                        this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 1");
                        p_memo1.Value = memo1Aloc;
                        break;
                    case 1:
                        memo2Aloc = memo2Aloc + memoProcesso;
                        this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 2");
                        p_memo2.Value = memo2Aloc;
                        break;
                    case 2:
                        memo3Aloc = memo3Aloc + memoProcesso;
                        this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 3");
                        p_memo3.Value = memo3Aloc;
                        break;
                    default:
                        MessageBox.Show("Não há espaço na memória dinâmica para alocação", "Informação", MessageBoxButtons.OK);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível alocar o processo nas memórias simuladas.", "Informação", MessageBoxButtons.OK);
            }
            t_comandos.Clear();
        }

        private void worstFitMethod(string nomeProcesso, int memoProcesso)
        {
            processos++;
            alocacao[0] = (memo1 - memo1Aloc - memoProcesso);
            alocacao[1] = (memo2 - memo2Aloc - memoProcesso);
            alocacao[2] = (memo3 - memo3Aloc - memoProcesso);

            try
            {
                int index = Array.IndexOf(alocacao, numerosPositivos(alocacao).Max());
                switch (index)
                {
                    case 0:
                        memo1Aloc = memo1Aloc + memoProcesso;
                        this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 1");
                        p_memo1.Value = memo1Aloc;
                        break;
                    case 1:
                        memo2Aloc = memo2Aloc + memoProcesso;
                        this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 2");
                        p_memo2.Value = memo2Aloc;
                        break;
                    case 2:
                        memo3Aloc = memo3Aloc + memoProcesso;
                        this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 3");
                        p_memo3.Value = memo3Aloc;
                        break;
                    default:
                        MessageBox.Show("Não há espaço na memória dinâmica para alocação", "Informação", MessageBoxButtons.OK);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível alocar o processo nas memórias simuladas.", "Informação", MessageBoxButtons.OK);
            }
            t_comandos.Clear();
        }

        private void firstFitMethod(string nomeProcesso, int memoProcesso)
        {
            processos++;
            alocacao[0] = (memo1 - memo1Aloc - memoProcesso);
            alocacao[1] = (memo2 - memo2Aloc - memoProcesso);
            alocacao[2] = (memo3 - memo3Aloc - memoProcesso);

            if (memoProcesso <= (memo1 - memo1Aloc))
            {
                memo1Aloc = memo1Aloc + memoProcesso;
                this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 1");
                p_memo1.Value = memo1Aloc;
            }
            else if (memoProcesso <= (memo2 - memo2Aloc))
            {
                memo2Aloc = memo2Aloc + memoProcesso;
                this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 2");
                p_memo2.Value = memo2Aloc;
            }
            else if (memoProcesso <= (memo2 - memo2Aloc))
            {
                memo3Aloc = memo3Aloc + memoProcesso;
                this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 3");
                p_memo3.Value = memo3Aloc;
            }
            else
            {
                MessageBox.Show("Não há espaço na memória dinâmica para alocação", "Informação", MessageBoxButtons.OK);
            }
            t_comandos.Clear();
        }

        private void swappingMethod(string nomeProcesso, int memoProcesso)
        {
            processos++;
            alocacao[0] = (memo1 - memo1Aloc - memoProcesso);
            alocacao[1] = (memo2 - memo2Aloc - memoProcesso);
            alocacao[2] = (memo3 - memo3Aloc - memoProcesso);

            if (memoProcesso <= (memo1 - memo1Aloc))
            {
                memo1Aloc = memo1Aloc + memoProcesso;
                this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 1");
                p_memo1.Value = memo1Aloc;
            }
            else if (memoProcesso <= (memo2 - memo2Aloc))
            {
                memo2Aloc = memo2Aloc + memoProcesso;
                this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 2");
                p_memo2.Value = memo2Aloc;
            }
            else if (memoProcesso <= (memo3 - memo3Aloc))
            {
                memo3Aloc = memo3Aloc + memoProcesso;
                this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Executando", memoProcesso, command, "Memória 3");
                p_memo3.Value = memo3Aloc;
            }
            else
            {
                try
                {
                    storageAloc = storageAloc + memoProcesso;
                    this.dg_processos.Rows.Add(processos, nomeProcesso.ToUpper(), "Em espera", memoProcesso, command, "Em armazenamento");
                    p_armazenamento.Value = storageAloc;
                }
                catch
                {
                    MessageBox.Show("Não há espaço nas memórias para alocação", "Informação", MessageBoxButtons.OK);
                }

            }
            t_comandos.Clear();
        }


        private void killProcess(int process)
        {
            for (int i = 0; i < dg_processos.RowCount; i++)
            {
                if (Convert.ToInt32(dg_processos.Rows[i].Cells[0].Value) == process)
                {
                    indexRow = i;
                }
            }
            int memoryRelease = Convert.ToInt32(dg_processos.Rows[indexRow].Cells[3].Value);
            string memory = dg_processos.Rows[indexRow].Cells[5].Value.ToString();
            dg_processos.Rows.Remove(dg_processos.Rows[indexRow]);
            switch (memory)
            {
                case "Memória 1":
                    memo1Aloc = memo1Aloc - memoryRelease;
                    p_armazenamento.Value = memo1Aloc;
                    break;
                case "Memória 2":
                    memo2Aloc = memo2Aloc - memoryRelease;
                    p_memo2.Value = memo2Aloc;
                    break;
                case "Memória 3":
                    memo3Aloc = memo3Aloc - memoryRelease;
                    p_memo3.Value = memo3Aloc;
                    break;
                case "Em armazenamento":
                    storageAloc = storageAloc - memoryRelease;
                    p_armazenamento.Value = storageAloc;
                    break;
            }
            t_comandos.Clear();
        }

        private void runProcess(int process)
        {
            for (int i = 0; i < dg_processos.RowCount; i++)
            {
                if (Convert.ToInt32(dg_processos.Rows[i].Cells[0].Value) == process)
                {
                    indexRow = i;
                }
            }

            int pid = Convert.ToInt32(dg_processos.Rows[indexRow].Cells[0].Value);
            int memoryRelease = Convert.ToInt32(dg_processos.Rows[indexRow].Cells[3].Value);
            string processo = dg_processos.Rows[indexRow].Cells[1].Value.ToString();
            dg_processos.Rows.Remove(dg_processos.Rows[indexRow]);
            storageAloc = storageAloc - memoryRelease;
            p_armazenamento.Value = storageAloc;
            alocacao[0] = (memo1 - memo1Aloc - memoryRelease);
            alocacao[1] = (memo2 - memo2Aloc - memoryRelease);
            alocacao[2] = (memo3 - memo3Aloc - memoryRelease);
            
                if (memoryRelease <= (memo1 - memo1Aloc))
                {
                    memo1Aloc = memo1Aloc + memoryRelease;
                    this.dg_processos.Rows.Add(pid, processo.ToUpper(), "Executando", memoryRelease, command, "Memória 1");
                    p_memo1.Value = memo1Aloc;
                }
                else if (memoryRelease <= (memo2 - memo2Aloc))
                {
                    memo2Aloc = memo2Aloc + memoryRelease;
                    this.dg_processos.Rows.Add(pid, processo.ToUpper(), "Executando", memoryRelease, command, "Memória 2");
                    p_memo2.Value = memo2Aloc;
                }
                else if (memoryRelease <= (memo3 - memo3Aloc))
                {
                    memo3Aloc = memo3Aloc + memoryRelease;
                    this.dg_processos.Rows.Add(pid, processo.ToUpper(), "Executando", memoryRelease, command, "Memória 3");
                    p_memo3.Value = memo3Aloc;
                }
                else
                {
                    MessageBox.Show("Não há espaço nas memórias para alocação", "Informação", MessageBoxButtons.OK);
                }
            
            t_comandos.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) new(nome,tamanho) :: cria um novo processo de tamanho determinado.\r\r" +
                            "2) kill(pid) :: destrói um processo de pid determinado.\r\r"+
                            "3) run(pid) :: executa um processo que está em armazenamento.\r"+
                            "|>Somente em modo 'swapping'", "Comandos:", MessageBoxButtons.OK);
        }
    }
}
