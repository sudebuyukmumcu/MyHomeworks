using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCapDemo1
{
    public partial class Form1 : Form
    {
        private const int V = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewMethod();

        }

        private void NewMethod()
        {
            //Button button = new Button(); //buton nesnesini oluşturmuş oluyorum
            //button.Width = 50;
            //button.Height = 50;
            //this.Controls.Add(button); //ekrana eklemiş oluyoruz
            //64 adet butonum olsun istiyorum. Bunu 64 kez yazmak yerine;
            //döngü yapabilirsin ama üst üste bindirilmiş 64 buton olur. 
            //butonların her birine ayrı ayr erişmek istiyorsan.kısacası aynı işlemden farklı nesler oluşturup nları daha sonra kontrol altında tutmak istiyorsan;
            //array yapıyoruz.
            Button[,] buttons = new Button[8, 8]; //başlangıcım bu
                                                  //şimdi her satır için 8 e 8 lik buton koyucaz.
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //arrayleri genellikle sıfırdan başlatırız
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button(); //her buton bizim için her dfeasında yeni bir butondur. O yüzden her defasında newlememiz gerekir
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50; //sola 50 kaydır dedik. 64 tane butonu yan yana yerleştirir.

                    buttons[i, j].BackColor = (i + j) % 2 == V ? Color.Black : Color.White;

                    this.Controls.Add(buttons[i, j]); //burada this dediğimiz forma karşılık gelir.
                    //64 kez çalışmış üst üste butonlar koydu. 1. butonun başlangı değeri formun en uç noktası yani sıfır noktası.
                    //dolayısıyla bir değişken tanımlıcam. int top, int left seklinde for dan önce tanımladık.
                }
                //bizim her satır bittiğinde top += 50 demem lazım ki 2. satıra geçtiğide 50 artsın.
                top += 50;
                left = 0; //2. satıra geçtiğimde lefti sıfırlamam lazım
                //böylece 8 e 8 lik buton array i oluştu.
            }
        }
    }
}
