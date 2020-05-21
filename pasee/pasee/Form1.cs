using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasee
{
    public partial class Form1 : Form
    {
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        public void taezaza()
        {
            //MessageBox.Show(count.ToString());
            if (count == 0)
            {
                panel4.Visible = true;
                panel7.Visible = false;
                panel8.Visible = false;
                panel10.Visible = false;
                panel12.Visible = false;
                panel14.Visible = false;
                panel16.Visible = false;
                panel18.Visible = false;
                panel1.Visible = false;
            }
            else if (count == 1)
            {
                panel4.Visible = true;
                panel7.Visible = true;
                panel8.Visible = true;
                panel10.Visible = false;
                panel12.Visible = false;
                panel14.Visible = false;
                panel16.Visible = false;
                panel18.Visible = false;
                panel1.Visible = false;
            }
            else if (count == 2)
            {
                panel4.Visible = true;
                panel7.Visible = true;
                panel8.Visible = true;
                panel10.Visible = true;
                panel12.Visible = false;
                panel14.Visible = false;
                panel16.Visible = false;
                panel18.Visible = false;
                panel1.Visible = false;
            }
            else if (count == 3)
            {
                panel4.Visible = true;
                panel7.Visible = true;
                panel8.Visible = true;
                panel10.Visible = true;
                panel12.Visible = true;
                panel14.Visible = false;
                panel16.Visible = false;
                panel18.Visible = false;
                panel1.Visible = false;
            }
            else if (count == 4)
            {
                panel4.Visible = true;
                panel7.Visible = true;
                panel8.Visible = true;
                panel10.Visible = true;
                panel12.Visible = true;
                panel14.Visible = true;
                panel16.Visible = false;
                panel18.Visible = false;
                panel1.Visible = false;
            }
            else if (count == 5)
            {
                panel4.Visible = true;
                panel7.Visible = true;
                panel8.Visible = true;
                panel10.Visible = true;
                panel12.Visible = true;
                panel14.Visible = true;
                panel16.Visible = true;
                panel18.Visible = false;
                panel1.Visible = false;
            }
            else if (count == 6)
            {
                panel4.Visible = true;
                panel7.Visible = true;
                panel8.Visible = false;
                panel10.Visible = false;
                panel12.Visible = false;
                panel14.Visible = false;
                panel16.Visible = false;
                panel18.Visible = true;
                panel1.Visible = false;
            }
            else if(count==7)
            {
                int x = (int.Parse(textBox6.Text) * 12) + int.Parse(textBox5.Text) + int.Parse(textBox4.Text);
                int y = 0;
                //ลดหย่อนตัวเอง
                y = y + 60000;
                //สถานะสมรส
                if (comboBox1.SelectedItem.ToString() == "คู่สมรสไม่มีเงินได้")
                {
                    y = y + 70000;
                    //ลดหย่อนบิดามารดาคู่สมรส
                    if (comboBox3.SelectedItem.ToString() == "1")
                    {
                        y = y + 30000;
                    }
                    else if (comboBox3.SelectedItem.ToString() == "2")
                    {
                        y = y + 60000;

                    }
                    //ลดหย่อนบิดามารดาตัวเอง
                    if (comboBox2.SelectedItem.ToString() == "1")
                    {
                        y = y + 30000;
                    }
                    else if (comboBox2.SelectedItem.ToString() == "2")
                    {
                        y = y + 60000;

                    }

                }
                else
                {
                    //ลดหย่อนบิดามารดาตัวเอง
                    if (comboBox2.SelectedItem.ToString() == "1")
                    {
                        y = y + 30000;
                    }
                    else if (comboBox2.SelectedItem.ToString() == "2")
                    {
                        y = y + 60000;

                    }

                }
                //ลดหย่อนบุตร
                if (int.Parse(textBox11.Text) != 0)
                {
                    //มีบุตรที่เกิดตั้งเเต่ปี2561สามคนขึ้นไป
                    if (int.Parse(textBox9.Text) + int.Parse(textBox11.Text) >= 3)
                    {
                        y = y + (int.Parse(textBox9.Text) + int.Parse(textBox11.Text) * 30000);
                        y = y + 60000;

                    }
                    //ไม่มีบุตรที่เกิดตั้งเเต่ปี2561สามคนขึ้นไป
                    else
                    {

                        y = y + (int.Parse(textBox9.Text) + int.Parse(textBox11.Text) * 30000);
                    }
                }
                //ไม่มีบุตรที่เกิดตั้งเเต่ปี2561ขึ้นไป
                else
                {
                    y = y + int.Parse(textBox9.Text) * 30000;

                }
                //ค่าคลอดบุตร
                if (int.Parse(textBox12.Text) <= 60000)
                {
                    y = y + int.Parse(textBox12.Text);

                }
                else
                {
                    y = y + 60000;

                }
                //ค่าอุปการคนพิการ
                y = y + (int.Parse(textBox10.Text) * 60000);
                //ประกันสังคม
                if (int.Parse(textBox16.Text) <= 9000)
                {
                    y = y + int.Parse(textBox16.Text);

                }
                else
                {
                    y = y + 9000;

                }
                //เบี้ยประกันชีวิตประกันสุขภาพ
                if (int.Parse(textBox7.Text) <= 100000)
                {
                    y = y + int.Parse(textBox7.Text);

                }
                else
                {
                    y = y + 100000;

                }
                //เบี้ยประกันสุขภาพบิดามารดา
                if (int.Parse(textBox8.Text) <= 15000)
                {
                    y = y + int.Parse(textBox8.Text);

                }
                else
                {
                    y = y + 15000;

                }
                //เบี้ยประกันกองทุนเลี้ยงชีพ
                if (int.Parse(textBox14.Text) <= 10000)
                {
                    y = y + int.Parse(textBox14.Text);

                }
                else
                {
                    y = y + 10000;

                }
                //กองทุนกบข
                if (int.Parse(textBox15.Text) <= 500000)
                {
                    y = y + int.Parse(textBox15.Text);

                }
                else
                {
                    y = y + 500000;

                }
                //เงินสะสมก.อ.ช.
                if (int.Parse(textBox17.Text) <= 13200)
                {
                    y = y + int.Parse(textBox17.Text);

                }
                else
                {
                    y = y + 13200;

                }
                //เเบบบำนาญ
                if (int.Parse(textBox23.Text) <= 500000)
                {
                    y = y + int.Parse(textBox23.Text);

                }
                else
                {
                    y = y + 500000;

                }
                //ซื้อLTF
                if (int.Parse(textBox21.Text) <= 500000)
                {
                    y = y + int.Parse(textBox21.Text);

                }
                else
                {
                    y = y + 500000;

                }
                //RMF
                if (int.Parse(textBox20.Text) <= 500000)
                {
                    y = y + int.Parse(textBox20.Text);

                }
                else
                {
                    y = y + 500000;

                }
                //ดอกเบี้ยบ้าน
                if (int.Parse(textBox22.Text) <= 100000)
                {
                    y = y + int.Parse(textBox22.Text);

                }
                else
                {
                    y = y + 100000;

                }
                //บ้านหรือคอนโดหลังเเรก
                if (int.Parse(comboBox4.SelectedItem.ToString()) >= 2562)
                {
                    //ซื้อตั้งเเต่ปี62ขึ้นไป
                    if (int.Parse(textBox18.Text) <= 5000000)
                    {
                        if (int.Parse(textBox18.Text) >= 200000)
                        {
                            y = y + 200000;
                        }
                        else
                        {
                            y = y + int.Parse(textBox18.Text);
                        }

                    }

                }
                else
                {
                    //ซื้อหลังปี62
                    if (int.Parse(textBox18.Text) <= 3000000)
                    {
                        y = y + (int.Parse(textBox18.Text) * 4 / 100);

                    }

                }
                //บริจาคให้พรรคการเมือง
                if (int.Parse(textBox25.Text) <= 10000)
                {
                    y = y + int.Parse(textBox25.Text);

                }
                else
                {
                    y = y + 10000;

                }
                //การศึกษาเเละกีฬา
                if (int.Parse(textBox30.Text) <= 15000)
                {
                    y = y + int.Parse(textBox30.Text);

                }
                else
                {
                    y = y + 15000;

                }
                //ซื้อหนังสือ
                if (int.Parse(textBox26.Text) <= 15000)
                {
                    y = y + int.Parse(textBox26.Text);

                }
                else
                {
                    y = y + 15000;

                }
                //ซื้อสินต้าotop
                if (int.Parse(textBox27.Text) <= 15000)
                {
                    y = y + int.Parse(textBox27.Text);

                }
                else
                {
                    y = y + 15000;

                }
                //ท่องเที่ยวไทย
                if (int.Parse(textBox28.Text) + int.Parse(textBox29.Text) <= 20000)
                {
                    y = y + int.Parse(textBox28.Text) + int.Parse(textBox29.Text);

                }
                else
                {
                    y = y + 20000;

                }
                //พายุปาบึก
                if (int.Parse(textBox31.Text) + int.Parse(textBox32.Text) <= 100000)
                {
                    y = y + int.Parse(textBox31.Text) + int.Parse(textBox32.Text);

                }
                else
                {
                    y = y + 100000;

                }
                //มรสุมตะวันตกเฉียงใต้
                if (int.Parse(textBox35.Text) + int.Parse(textBox36.Text) <= 100000)
                {
                    y = y + int.Parse(textBox35.Text) + int.Parse(textBox36.Text);

                }
                else
                {
                    y = y + 100000;

                }
                //เงินบริจาคสนันสนุนการศึกษา
                if (int.Parse(textBox19.Text) * 2 <= (x - y) * 10 / 100)
                {
                    y = y + int.Parse(textBox19.Text) * 2;
                }
                //บริจาคทั่วไป
                if (int.Parse(textBox24.Text) <= (x - y) * 10 / 100)
                {
                    y = y + int.Parse(textBox24.Text);
                }
                panel4.Visible = true;
                panel7.Visible = true;
                panel8.Visible = false;
                panel10.Visible = false;
                panel12.Visible = false;
                panel14.Visible = false;
                panel16.Visible = false;
                panel18.Visible = false;
                panel1.Visible = true;
                textBox33.Text = x.ToString();
                int total = x - y;
                int pasee;
                textBox2.Text = total.ToString();
                //คำนวญภาษี
                if (total > 5000000)
                    pasee = 35;
                else if(total > 2000000)
                    pasee = 30;
                else if (total > 1000000)
                    pasee = 25;
                else if (total > 750000)
                    pasee = 20;
                else if (total > 500000)
                    pasee = 15;
                else if (total > 300000)
                    pasee = 10;
                else if (total > 150000)
                    pasee = 5;
                else
                    pasee = 0;
                textBox34.Text = y.ToString();
                textBox3.Text = (total*pasee/100).ToString();
                textBox1.Text = (total - (total * pasee / 100)).ToString();


            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Form2 fm2 = new Form2();
            fm2.Show();*/
            
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count += 1;
            taezaza();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count -= 1;
            taezaza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count += 1;
            taezaza();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            count -= 1;
            taezaza();
        }
    }
}
