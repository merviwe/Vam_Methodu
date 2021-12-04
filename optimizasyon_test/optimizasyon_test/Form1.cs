using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optimizasyon_test
{
    public partial class Form1 : Form
    {
        public int matris_x;
        public int matris_y;
        public int artis = 0;
    
        public Form1()
        {
           
            InitializeComponent();
        }
        //Dinamik olarak oluşturulan textboxların sadece nümerik ifadeleri kabul etmesini sağlayan event.
        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fabrika ve Şehir sayısının boş oluo olmadığı kontrol edildi.
            if(fabrika_input.Text=="")
            {
                MessageBox.Show("Fabrika sayısı boş olamaz!");
            }
            if (sehir_input.Text == "")
            {
                MessageBox.Show("Şehir sayısı boş olamaz!");
            }

            //Eğer fabrika ve şehir sayısı boş değilse işlemlere başlandı.
            if (fabrika_input.Text != "" && sehir_input.Text != "")
            {
               
                if (Convert.ToInt32(fabrika_input.Text) <=15 && Convert.ToInt32(sehir_input.Text) <= 15 && Convert.ToInt32(fabrika_input.Text) != 0 && Convert.ToInt32(sehir_input.Text)!= 0)
                {

                    //Bir matris oluşturuldu; x ve y boyutlarına fabrika ve şehir değişkenleri atandı.
                    int[,] matris = new int[matris_x, matris_y];
                    matris_x = Convert.ToInt32(fabrika_input.Text);
                    matris_y = Convert.ToInt32(sehir_input.Text);

                    degerler deger = new degerler();
                    Form1 f1 = new Form1();
                    TextBox[] line = new TextBox[(matris_x) + 1];
                    Label[] baslikdizisi = new Label[(matris_x) + 1];
                    TextBox[] column = new TextBox[(matris_y) + 1];
                    Label[] basliksehirr = new Label[(matris_y) + 1];

                    //Dinamik textboxlar oluşturuldu ve gerekli propertyler atandı.
                    //Sütun kısmı
                    for (int i = 0; i < line.Length; i++)
                    {
                        var txt = new TextBox();
                        var baslik = new Label();
                        baslikdizisi[i] = baslik;
                        baslik.Width = 75;
                        baslik.Height = 25;
                        baslik.Visible = true;
           
                        baslik.Location = new Point(25, 50 + artis);
                        baslik.Text =  "F"+(i+1).ToString();
                        deger.Controls.Add(baslik);
                        if (i+1==line.Length)
                        {
                           
                            baslikdizisi[i] = baslik;
                            baslik.Width = 75;
                            baslik.Height = 25;
                            baslik.Visible = true;
                            baslik.Location = new Point(25, 50 + artis);
                            baslik.Text = "Talep" ;
                            
                            deger.Controls.Add(baslik);
                           
                        }

                        txt.KeyPress += txt_KeyPress;
                        line[i] = txt;
                        txt.Width = 25;
                        txt.Height = 25;
                        txt.Location = new Point(100, 50 + artis);

                        txt.Visible = true;
                        deger.Controls.Add(txt);
                    
                       
                        //Satır Kısmı
                        for (int j = 0; j < column.Length; j++)
                        {
                            var txtt = new TextBox();

                            var basliksehir = new Label();
                            basliksehirr[j] = basliksehir;
                            basliksehir.Width = 25;
                            basliksehir.Height = 25;
                            basliksehir.Text =(j+1).ToString() ;
                            basliksehir.Visible = true;
                           
                            basliksehir.Location = new Point(100 + (j) * 28, 10);
                            deger.Controls.Add(basliksehir);
                            
                            txtt.KeyPress += txt_KeyPress;
                            column[j] = txtt;
                            txtt.Width = 25;
                            txtt.Height = 25;
                            txtt.Location = new Point(100 + (j * 28), 50 + artis);
                            txtt.Visible = true;
                            
                            deger.Controls.Add(txtt);

                            if (j + 1 == column.Length)
                            {
                              
                                basliksehirr[j] = basliksehir;
                                basliksehir.Width = 50;
                                basliksehir.Height = 25;
                                basliksehir.Visible = true;
                                basliksehir.Location = new Point(100 + (j) * 28, 10);
                                basliksehir.Text = "Arz"; 
                              
                                deger.Controls.Add(basliksehir);
                            }

                        }
                      
                        artis += 36;
                    }

                    deger.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Matris boyutları hatalı!");
                }

            }
        }
        
        private void fabrika_input_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fabrika_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void sehir_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
