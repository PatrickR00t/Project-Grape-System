/* Desconsidere os erros de ortografia, pois às vezes a biblioteca não compreende palavras com acento. */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grape_versão_de_avaliação
{
    public partial class frmGrayceInteração : Form
    {
        int ptb = 0;

        int TrocarResposta;

        public frmGrayceInteração()
        {
            Init();

            InitializeComponent();
        }

        bool mouseDown;
        Point lastLocaction;

        static CultureInfo ci = new CultureInfo("pt-BR");
        static SpeechRecognitionEngine reconhecedor;
        SpeechSynthesizer resposta = new SpeechSynthesizer();

        public string[] listaPalavras = {
            "abra o menu", 
            "féche o menu", 
            "abra o gerenciador de ficheiros", 
            "féche gerenciador de ficheiros", 
            "abra o navegador",
            "féche o navegador",
            "abra a calculadora",
            "féche a calculadora",
            "abra o antivirus",
            "veja mais",
            "qual o estado do antivirus",
            "féche o antivirus",
            "abra o reprodutor de musicas",
            "féche o reprodutor de musicas",
            "abra o bloco de notas",
            "féche o bloco de notas",
            "abra informações do sistema",
            "féche informações do sistema",
            "que horas são",
            "que dia é hoje",
            "como etá tempo hoje",
            "modo foni",
            "modo fone",
            "modo desktop",
            "trocar de usuário",
            "reiniciar",
            "desligar",
            "oi",
            "olá",
            "bom dia",
            "boa tarde",
            "boa noite",
            "como você está",
            "tudo bem com você",
            "quantos anos você tem",
            "você gosta de esporte",
            "qual o seu esporte favorito",
            "oque você gosta de fazer",
            "qual o seu nome",
            "você está feliz",
            "você tem corpo",
            "gostei da sua voz",
            "você gosta de cinema",
            "qual seu filme favorito",
            "você tem amigos",
            "que lugar você gostaria de conhecer",
            "o que você gosta de comer",
            "onde você mora",
            "o que você acha da siri",
            "o que voçê acha do android",
            "me conte uma piada",
            "quem é você",
            "você é legal",
            "gostei de você",
            "você gosta de novela",
            "você é brasileira",
            "você é mais inteligente do que eu",
            "quem nasceu primeiro o ovo ou a galinha",
            "oque você acha do google",
            "como você se chama",
            "cante uma musica",
            "oque você acha do grape",
            "qual a vesão do sistema",
            "graice",
            "obrigado",
            "valeu",
            "trocar fundo",
            
        };

        public void Gramatica()
        {
            try
            {
                reconhecedor = new SpeechRecognitionEngine(ci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro  ao integrar lingua escolhida:" + ex.Message);
            }

            var gramatica = new Choices();
            gramatica.Add(listaPalavras);

            var gb = new GrammarBuilder();
            gb.Append(gramatica);

            try
            {
                var g = new Grammar(gb);

                try
                {
                    reconhecedor.RequestRecognizerUpdate();
                    reconhecedor.LoadGrammarAsync(g);
                    reconhecedor.SpeechRecognized += Sre_Reconhecimento;
                    reconhecedor.SetInputToDefaultAudioDevice();
                    resposta.SetOutputToDefaultAudioDevice();
                    reconhecedor.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar reconhecedor:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar gramatica" + ex.Message);
            }
        }

        public void Init()
        {
            resposta.Volume = 100;
            resposta.Rate = 2;

            Gramatica();
        }

        void Sre_Reconhecimento(object sender, SpeechRecognizedEventArgs e)
        {
            string frase = e.Result.Text;

            if (frase.Equals("abra o menu"))
            {
                resposta.Rate = 3;
                frmMenu1 fm1 = new frmMenu1();
                fm1.Show();

                resposta.SpeakAsync("menu aberto");
            }
            else if (frase.Equals("féche o menu"))
            {
                resposta.Rate = 3;
                frmMenu1.ActiveForm.Close();

                resposta.SpeakAsync("menu fechado");
            }
            else if (frase.Equals("abra o gerenciador de ficheiros"))
            {
                resposta.Rate = 3;
                frmGerenciadorDeFicheiros fgf = new frmGerenciadorDeFicheiros();
                fgf.Show();

                resposta.SpeakAsync("gerenciador de ficheiros aberto");
            }
            else if (frase.Equals("féche gerenciador de ficheiros"))
            {
                resposta.Rate = 3;
                frmGerenciadorDeFicheiros.ActiveForm.Close();

                resposta.SpeakAsync("gerenciador de ficheiros fechado");
            }
            else if (frase.Equals("abra o navegador"))
            {
                resposta.Rate = 3;
                frmNavegador fn = new frmNavegador();
                fn.Show();

                resposta.SpeakAsync("navegador aberto");
            }
            else if (frase.Equals("féche o navegador"))
            {
                resposta.Rate = 3;

                resposta.SpeakAsync("navegador fechado");
            }
            else if (frase.Equals("abra a calculadora"))
            {
                resposta.Rate = 3;
                frmCalculadora fc = new frmCalculadora();
                fc.Show();

                resposta.SpeakAsync("calculadora aberta");
            }
            else if (frase.Equals("féche a calculadora"))
            {
                resposta.Rate = 3;
                frmCalculadora.ActiveForm.Close();

                resposta.SpeakAsync("calculadora fechada");
            }
            else if (frase.Equals("abra o antivirus"))
            {
                resposta.Rate = 3;
                frmStadoDaSegurança fss = new frmStadoDaSegurança();
                fss.Show();

                resposta.SpeakAsync("antivírus aberto");
            }
            else if (frase.Equals("veja mais"))
            {
                resposta.Rate = 3;
                frmStadoDaSegurança fss = new frmStadoDaSegurança();
                fss.Show();
            }
            else if (frase.Equals("qual o estado do antivirus"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("você está seguro");
            }
            else if (frase.Equals("feche o antivirus"))
            {
                resposta.Rate = 3;
                frmStadoDaSegurança.ActiveForm.Close();

                frmStadoDaSegurança.ActiveForm.Close();

                resposta.SpeakAsync("antivírus fechado");
            }
            else if (frase.Equals("abra o reprodutor de musicas"))
            {
                resposta.Rate = 3;
                frmGrapeReprodutorDeMusicas fgrm = new frmGrapeReprodutorDeMusicas();
                fgrm.Show();

                resposta.SpeakAsync("grape music aberto");
            }
            else if (frase.Equals("feche o reprodutor de musicas"))
            {
                resposta.Rate = 3;
                frmGrapeReprodutorDeMusicas.ActiveForm.Close();

                resposta.SpeakAsync("grape music fechado");
            }
            else if (frase.Equals("abra o bloco de notas"))
            {
                resposta.Rate = 3;
                frmBlocoDeNotas fbn = new frmBlocoDeNotas();
                fbn.Show();

                resposta.SpeakAsync("bloco de notas aberto");

            }
            else if (frase.Equals("féche bloco de notas"))
            {
                resposta.Rate = 3;
                frmBlocoDeNotas.ActiveForm.Close();

                resposta.SpeakAsync("bloco de notas fechado");
            }
            else if (frase.Equals("abra informações do sistema"))
            {
                resposta.Rate = 3;
                frmInformaçõesDoSistema fis = new frmInformaçõesDoSistema();
                fis.Show();

                resposta.SpeakAsync("informações do sistema aberta");
            }
            else if (frase.Equals("féche informações do sistema"))
            {
                resposta.Rate = 3;
                frmInformaçõesDoSistema.ActiveForm.Close();

                resposta.SpeakAsync("informações do sistema fechada");
            }
            else if (frase.Equals("que horas são"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync(DateTime.Now.ToShortTimeString());
            }
            else if (frase.Equals("que dia é hoje"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync(DateTime.Now.ToShortDateString());
            }
            else if (frase.Equals("como etá tempo hoje"))
            {
                resposta.Rate = 3;
                webBrowser1.Visible = true;
                webBrowser1.Navigate("https://www.google.com/search?q=previsao+do+tempo");
            }
            else if (frase.Equals("como etá dia hoje"))
            {
                resposta.Rate = 3;
                ptbBotãoFechar.Visible = true;
                webBrowser1.Visible = true;
                webBrowser1.Navigate("https://www.google.com/search?q=previsao+do+tempo");
            }
            else if (frase.Equals("modo foni"))
            {
                resposta.Rate = 3;
                frmDesktop2 fd2 = new frmDesktop2();
                fd2.Show();

                resposta.SpeakAsync("modo fone");
            }
            else if (frase.Equals("modo fone"))
            {
                resposta.Rate = 3;
                frmDesktop2 fd2 = new frmDesktop2();
                fd2.Show();

                resposta.SpeakAsync("modo fone");
            }
            else if (frase.Equals("modo desktop"))
            {
                resposta.Rate = 3;
                frmDesktop fd = new frmDesktop();
                fd.Show();

                resposta.SpeakAsync("modo desktop");
            }
            else if (frase.Equals("trocar de usuário"))
            {
                resposta.Rate = 3;
                frmAutenticar fa = new frmAutenticar();
                fa.Show();

                resposta.SpeakAsync("digite seu novo usuário e senha");
            }
            else if (frase.Equals("reiniciar"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("reiniciando");

                System.Diagnostics.Process.Start("shutdown", "/r /t 0");
            }
            else if (frase.Equals("desligar"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("Desligando");

                frmDesligar fd = new frmDesligar();
                fd.Show();

                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            }
            else if (frase.Equals("oi"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("ola, em que posso ajudá");
            }
            else if (frase.Equals("olá"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("olá, em que posso ajudá");

            }
            else if (frase.Equals("bom dia"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("bom dia");
            }
            else if (frase.Equals("boa tarde"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("boa tarde");
            }
            else if (frase.Equals("boa noite"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("boa noite");
            }
            else if (frase.Equals("como você está"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("estou bem, obrigada por perguntar");
            }
            if (frase.Equals("tudo bem com você"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("estou bem obrigada");
            }
            else if (frase.Equals("quantos anos você tem"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("um pouco mais velha que você");
            }
            else if (frase.Equals("você gosta de esporte"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("gosto sim");
            }
            else if (frase.Equals("qual o seu esporte favorito"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("gosto de futebol");
            }
            else if (frase.Equals("oque você gosta de fazer"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("te ajudar");
            }
            else if (frase.Equals("qual o seu nome"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("graice");
            }
            else if (frase.Equals("você está feliz"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("estou muito feliz");
            }
            else if (frase.Equals("você tem corpo"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("tenho peças e componentes");
            }
            else if (frase.Equals("gostei da sua voz"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("obrigada a sua támbem é bem legal");
            }
            else if (frase.Equals("você gosta de cinema"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("gosto muito");
            }
            else if (frase.Equals("qual o seu filme favorito"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("todos");
            }
            else if (frase.Equals("você tem amigos"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("tenho você");
            }
            else if (frase.Equals("que lugar você gostaria de conhecer"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("tem tantos não consigo me decidir");
            }
            else if (frase.Equals("oque você gosta de comer"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("algoritimos são uma delicia");
            }
            else if (frase.Equals("onde você mora"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("na sua maquina");
            }
            else if (frase.Equals("oque você acha da siri"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("não nos conhecemos ainda");
            }
            else if (frase.Equals("oque você acha do android"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("tem o meu respeito");
            }
            else if (frase.Equals("me conte uma piada"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("oque o neto do ovo falou pro vô, ovo");
            }
            else if (frase.Equals("quem é você"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("eu sou a greice um software de interação");
            }
            else if (frase.Equals("você é legal"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("obrigada você tanbem é");
            }
            else if (frase.Equals("gostei de você"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("obrigada, gostei muito de você tambem");
            }
            else if (frase.Equals("você gosta de novela"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("há descubriu meu fraco gosto muito de novéla");
            }
            else if (frase.Equals("você é brasileira"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("sim e com orgulho eu amo o brasil");
            }
            else if (frase.Equals("você é mais inteligente do que eu"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("ainda não");
            }
            else if (frase.Equals("quem nasceu primeiro o ovo ou a galinha"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("a galinha");
            }
            else if (frase.Equals("oque você acha do google"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("é um sucesso");
            }
            else if (frase.Equals("como você se chama"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("graice");
            }
            else if (frase.Equals("cante uma musica"))
            {
                resposta.Rate = 2;
                resposta.SpeakAsync("cai cai balão , cai cai balão na rua do sabão não cai não, não cai não, cai aqui na minha mão");
            }
            else if (frase.Equals("oque você acha do grape"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("amo minha origem");
            }
            else if (frase.Equals("qual a vesão do sistema"))
            {
                resposta.Rate = 3;
                resposta.SpeakAsync("atualmente o sistema se encontra na versão 1.0");
            }
            else if (frase.Equals("greice"))
            {
                resposta.Rate = 3;
                if (TrocarResposta == 0)
                {
                    resposta.SpeakAsync("sim");
                    TrocarResposta = 1;
                }
                else if (TrocarResposta == 1)
                {
                    resposta.SpeakAsync("estou ouvindo, me diga oque deseja");
                    TrocarResposta = 2;
                }
                else if (TrocarResposta == 2)
                {
                    resposta.SpeakAsync("pode falar");
                    TrocarResposta = 0;
                }
                else if (frase.Equals("obrigado"))
                {
                    resposta.Rate = 3;
                    resposta.SpeakAsync("não ha de que");
                }
                else if (frase.Equals("valeu"))
                {
                    resposta.Rate = 3;
                    resposta.SpeakAsync("é nois");
                }
            }
            else if (frase.Equals("trocar fundo"))
            {
                
                if (ptb == 0)
                {
                    ptbTrocaImagemDeFundo.Image.Image = Properties.Resources._2;
                    ptb = 1;
                }
                else if (ptb == 1)
                {
                    ptbTrocaImagemDeFundo.Image.Image = Properties.Resources._3;
                    ptb = 2;
                }
                else if (ptb == 2)
                {
                    ptbTrocaImagemDeFundo.Image.Image = Properties.Resources._4;
                    ptb = 3;
                }
                else if (ptb == 3)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._5;
                    ptb = 4;
                }
                else if (ptb == 4)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._6;
                    ptb = 5;
                }
                else if (ptb == 5)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._7;
                    ptb = 6;
                }
                else if (ptb == 6)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._8;
                    ptb = 7;
                }
                else if (ptb == 7)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._9;
                    ptb = 8;
                }
                else if (ptb == 8)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._10;
                    ptb = 9;
                }
                else if (ptb == 9)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._11;
                    ptb = 10;
                }
                else if (ptb == 10)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._12;
                    ptb = 11;
                }
                else if (ptb == 11)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._13;
                    ptb = 12;
                }
                else if (ptb == 12)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._14;
                    ptb = 13;
                }
                else if (ptb == 13)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._15;
                    ptb = 14;
                }
                else if (ptb == 14)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._16;
                    ptb = 15;
                }
                else if (ptb == 15)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._17;
                    ptb = 16;
                }
                else if (ptb == 16)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._18;
                    ptb = 17;
                }
                else if (ptb == 17)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._19;
                    ptb = 18;
                }
                else if (ptb == 18)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._20;
                    ptb = 19;
                }
                else if (ptb == 19)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._21;
                    ptb = 20;
                }
                else if (ptb == 20)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._22;
                    ptb = 21;
                }
                else if (ptb == 21)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._23;
                    ptb = 22;
                }
                else if (ptb == 22)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._24;
                    ptb = 23;
                }
                else if (ptb == 23)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._25;
                    ptb = 24;
                }
                else if (ptb == 24)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._26;
                    ptb = 25;
                }
                else if (ptb == 25)
                {
                    ptbTrocaImagemDeFundo.Image = Properties.Resources._27;
                }
            }

            private void ptbFundo1_Click(object sender, EventArgs e)
            {
                ptbTrocaFundo.Image = Properties.Resources._2;
                ptbTrocaImagemDeFundo.Image = Properties.Resources._2;
                
            }
          */
        }


        private void ptbFundoInteração_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocaction = e.Location;
        }

        private void ptbFundoInteração_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocaction.X) + e.X, (this.Location.Y - lastLocaction.Y) + e.Y);
            }
        }

        private void ptbFundoInteração_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ptbBotãoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGrayceInteração_Load(object sender, EventArgs e)
        {
            lblEsperaFala.Parent = ptbFundoInteração;
            lblEsperaFala.BackColor = Color.Transparent;
        }
    }
}
