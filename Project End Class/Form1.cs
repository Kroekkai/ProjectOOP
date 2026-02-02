using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_End_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double password;
        private void NewPassword_Click(object sender, EventArgs e)
        {
            try
            {
                double NP, Con;                                                               //code สร้างรหัส
                NP = Convert.ToInt16(NPassword.Text);
                Con = Convert.ToInt16(confirm.Text);
                password = Con;
                if (NP == Con)
                {
                    MessageBox.Show("สร้างรหัสสำเร็จ");

                }
                else
                {
                    MessageBox.Show("สร้างรหัสไม่สำเร็จ");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }
        private void Password_Click(object sender, EventArgs e)
        {
            try
            {
                double login;                                                                          // code เข้ารหัสและบังคับให้ เข้ารหัส ถ้าไม่เข้ารหัสจะไม่สามารถดูสินค้าและใส่ข้อมูลสมาชิก
                login = Convert.ToInt16(pass.Text);
                if (login == password)
                {
                    MessageBox.Show("รหัสถูกต้อง");
                    btnMember.Enabled = true;

                                                                                                
                    //Case 
                    pictureBox2.ImageLocation = Application.StartupPath + "\\Case1.jpg";                        //code รูป และ เปิดtextboxจำนวนของ Case
                    pictureBox3.ImageLocation = Application.StartupPath + "\\Case2.jpg";
                    pictureBox4.ImageLocation = Application.StartupPath + "\\Case3.png";
                    pictureBox5.ImageLocation = Application.StartupPath + "\\Case4.jpg";
                    pictureBox7.ImageLocation = Application.StartupPath + "\\Case5.png";
                    txtCase1.Enabled = true;
                    txtCase2.Enabled = true;
                    txtCase3.Enabled = true;
                    txtCase4.Enabled = true;
                    txtCase5.Enabled = true;
                                                                                                 
                    //CPU
                    pictureBox8.ImageLocation = Application.StartupPath + "\\CPU1.jpg";                         //code รูป และ เปิดtextboxจำนวนของ CPU
                    pictureBox9.ImageLocation = Application.StartupPath + "\\CPU2.jpg";
                    pictureBox10.ImageLocation = Application.StartupPath + "\\CPU3.png";
                    pictureBox11.ImageLocation = Application.StartupPath + "\\CPU4.jpg";
                    pictureBox12.ImageLocation = Application.StartupPath + "\\CPU5.jpg";
                    txtCPU1.Enabled = true;
                    txtCPU2.Enabled = true;
                    txtCPU3.Enabled = true;
                    txtCPU4.Enabled = true;
                    txtCPU5.Enabled = true;

                    //Graphic Card
                    pictureBox13.ImageLocation = Application.StartupPath + "\\Card1.png";                       //code รูป และ เปิดtextboxจำนวนของ Graphic Card
                    pictureBox14.ImageLocation = Application.StartupPath + "\\Card2.jpg";
                    pictureBox15.ImageLocation = Application.StartupPath + "\\Card3.jpg";
                    pictureBox16.ImageLocation = Application.StartupPath + "\\Card4.jpg";
                    pictureBox17.ImageLocation = Application.StartupPath + "\\Card5.jpg";
                    txtCard1.Enabled = true;
                    txtCard2.Enabled = true;
                    txtCard3.Enabled = true;
                    txtCard4.Enabled = true;
                    txtCard5.Enabled = true;

                    //HDD
                    pictureBox18.ImageLocation = Application.StartupPath + "\\HDD1.jpg";                        //code รูป และ เปิดtextboxจำนวนของ HDD
                    pictureBox19.ImageLocation = Application.StartupPath + "\\HDD2.jpg";
                    pictureBox20.ImageLocation = Application.StartupPath + "\\HDD3.jpg";
                    pictureBox21.ImageLocation = Application.StartupPath + "\\HDD4.jpg";
                    pictureBox22.ImageLocation = Application.StartupPath + "\\HDD5.jpg";
                    txtHDD1.Enabled = true;
                    txtHDD2.Enabled = true;
                    txtHDD3.Enabled = true;
                    txtHDD4.Enabled = true;
                    txtHDD5.Enabled = true;


                    //Keyboad
                    pictureBox23.ImageLocation = Application.StartupPath + "\\KB1.jpg";                         //code รูป และ เปิดtextboxจำนวนของ Keyboad
                    pictureBox24.ImageLocation = Application.StartupPath + "\\KB2.jpg";
                    pictureBox25.ImageLocation = Application.StartupPath + "\\KB3.jpg";
                    pictureBox26.ImageLocation = Application.StartupPath + "\\KB4.jpg";
                    pictureBox27.ImageLocation = Application.StartupPath + "\\KB5.jpg";
                    txtkeyboad1.Enabled = true;
                    txtkeyboad2.Enabled = true;
                    txtkeyboad3.Enabled = true;
                    txtkeyboad4.Enabled = true;
                    txtkeyboad5.Enabled = true;

                    //Mainboad
                    pictureBox28.ImageLocation = Application.StartupPath + "\\MB1.jpg";                         //code รูป และ เปิดtextboxจำนวนของ Mainboad                     
                    pictureBox29.ImageLocation = Application.StartupPath + "\\MB2.jpg";
                    pictureBox30.ImageLocation = Application.StartupPath + "\\MB3.png";
                    pictureBox31.ImageLocation = Application.StartupPath + "\\MB4.jpg";
                    pictureBox32.ImageLocation = Application.StartupPath + "\\MB5.jpg";
                    txtMainboad1.Enabled = true;
                    txtMainboad2.Enabled = true;
                    txtMainboad3.Enabled = true;
                    txtMainboad4.Enabled = true;
                    txtMainboad5.Enabled = true;

                    //Monitor
                    pictureBox33.ImageLocation = Application.StartupPath + "\\Mon1.png";                        //code รูป และ เปิดtextboxจำนวนของ Monitor
                    pictureBox34.ImageLocation = Application.StartupPath + "\\Mon2.jpg";
                    pictureBox35.ImageLocation = Application.StartupPath + "\\Mon3.png";
                    pictureBox36.ImageLocation = Application.StartupPath + "\\Mon4.jpg";
                    pictureBox37.ImageLocation = Application.StartupPath + "\\Mon5.jpg";
                    txtMonitor1.Enabled = true;
                    txtMonitor2.Enabled = true;
                    txtMonitor3.Enabled = true;
                    txtMonitor4.Enabled = true;
                    txtMonitor5.Enabled = true;

                    //Mouse
                    pictureBox38.ImageLocation = Application.StartupPath + "\\Mouse1.png";                      //code รูป และ เปิดtextboxจำนวนของ Mouse
                    pictureBox39.ImageLocation = Application.StartupPath + "\\Mouse2.jpg";
                    pictureBox40.ImageLocation = Application.StartupPath + "\\Mouse3.jpg";
                    pictureBox41.ImageLocation = Application.StartupPath + "\\Mouse4.jpg";
                    pictureBox42.ImageLocation = Application.StartupPath + "\\Mouse5.jpg";
                    txtMouse1.Enabled = true;
                    txtMouse2.Enabled = true;
                    txtMouse3.Enabled = true;
                    txtMouse4.Enabled = true;
                    txtMouse5.Enabled = true;

                    //Power Supply
                    pictureBox43.ImageLocation = Application.StartupPath + "\\PSU1.png";                        //code รูป และ เปิดtextboxจำนวนของ Power Supply
                    pictureBox44.ImageLocation = Application.StartupPath + "\\PSU2.jpeg";
                    pictureBox45.ImageLocation = Application.StartupPath + "\\PSU3.jpg";
                    pictureBox46.ImageLocation = Application.StartupPath + "\\PSU4.jpg";
                    pictureBox47.ImageLocation = Application.StartupPath + "\\PSU5.jpg";
                    txtPSU1.Enabled = true;
                    txtPSU2.Enabled = true;
                    txtPSU3.Enabled = true;
                    txtPSU4.Enabled = true;
                    txtPSU5.Enabled = true;

                    //RAM
                    pictureBox48.ImageLocation = Application.StartupPath + "\\RAM1.jpg";                        //code รูป และ เปิดtextboxจำนวนของ RAM
                    pictureBox49.ImageLocation = Application.StartupPath + "\\RAM2.jpg";
                    pictureBox50.ImageLocation = Application.StartupPath + "\\RAM3.jpg";
                    pictureBox51.ImageLocation = Application.StartupPath + "\\RAM4.jpg";
                    pictureBox52.ImageLocation = Application.StartupPath + "\\RAM5.jpg";
                    txtRAM1.Enabled = true;
                    txtRAM2.Enabled = true;
                    txtRAM3.Enabled = true;
                    txtRAM4.Enabled = true;
                    txtRAM5.Enabled = true;

                    //Storage
                    pictureBox53.ImageLocation = Application.StartupPath + "\\SSD1.jpg";                        //code รูป และ เปิดtextboxจำนวนของ Storage
                    pictureBox54.ImageLocation = Application.StartupPath + "\\SSD2.jpg";
                    pictureBox55.ImageLocation = Application.StartupPath + "\\SSD3.jpg";
                    pictureBox56.ImageLocation = Application.StartupPath + "\\SSD4.jpg";
                    pictureBox57.ImageLocation = Application.StartupPath + "\\SSD5.jpg";
                    txtStorage1.Enabled = true;
                    txtStorage2.Enabled = true;
                    txtStorage3.Enabled = true;
                    txtStorage4.Enabled = true;
                    txtStorage5.Enabled = true;

                }
                else
                {
                    MessageBox.Show("รหัสไม่ถูกต้อง");
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }

        private void btnMember_Click(object sender, EventArgs e)
        {

                namelast.Text = Nametxt.Text + "   " + Lastnametxt.Text + "   " + txtago.Text + "\r\n"
                    + txtEmail.Text + "   " + txtphone.Text;                                                        // code ใส่ข้อมูลสมาชิก ถ้าไม่ใส่จะไม่สามารถใช้การเติมเงินได้

                pictureBox6.ImageLocation = Application.StartupPath + "\\fox.jpg";


                if (radioButton1.Checked == true)                                                                   //code เพศ
                {
                    if (checkBox1.Checked == true)                                                                  //code สถานะ
                        LG.Text = "เพศ" + "   " + radioButton1.Text + "\n" + "สถานะ" + "   " + checkBox1.Text;
                    if (checkBox2.Checked == true)                                                                  //code สถานะ
                        LG.Text = "เพศ" + "   " + radioButton1.Text + "\n" + "สถานะ" + "   " + checkBox2.Text;
                    if (checkBox3.Checked == true)                                                                  //code สถานะ
                        LG.Text = "เพศ" + "   " + radioButton1.Text + "\n" + "สถานะ" + "   " + checkBox3.Text;
                }
                else if (radioButton2.Checked == true)                                                              //code เพศ
                {
                    if (checkBox1.Checked == true)                                                                  //code สถานะ
                        LG.Text = "เพศ" + "   " + radioButton2.Text + "\n" + "สถานะ" + "   " + checkBox1.Text;
                    if (checkBox2.Checked == true)                                                                  //code สถานะ
                        LG.Text = "เพศ" + "   " + radioButton2.Text + "\n" + "สถานะ" + "   " + checkBox2.Text;
                    if (checkBox3.Checked == true)                                                                  //code สถานะ
                        LG.Text = "เพศ" + "   " + radioButton2.Text + "\n" + "สถานะ" + "   " + checkBox3.Text;
                }
                else                                                                                                //code เพศ
                {
                    if (checkBox1.Checked == true)                                                                  //code สถานะ
                        LG.Text = "เพศ" + "   " + radioButton3.Text + "\n" + "สถานะ" + "   " + checkBox1.Text;
                    if (checkBox2.Checked == true)                                                                  //code สถานะ
                        LG.Text = "เพศ" + "   " + radioButton3.Text + "\n" + "สถานะ" + "   " + checkBox2.Text;
                    if (checkBox3.Checked == true)                                                                  //code สถานะ
                        LG.Text = "เพศ" + "   " + radioButton3.Text + "\n" + "สถานะ" + "   " + checkBox3.Text;
                }
                btnNewATM.Enabled = true;


        }

        private void btnNewATM_Click(object sender, EventArgs e)
        {                                                                                                           //code ใส่ ชื่อบัตร เลขบัตร เดือน ปีหมดอายุ
                Namecard.Text = "ชื่อบัตร " + txtnamecard.Text + "\r\n" + "เลขบัตร " + txtnumcard.Text +
                    "\r\n" + txtagomon.Text + "/" + txtyearcard.Text + "\r\n" + txtpasscard.Text;
                if(radioButton4.Checked == true)                                                                    //code กดเลือกATM บัคคับเลือก 1ใน4 ธนาคารเพื่อใช้ปุ่มเติมเงิน
                {
                    pictureBox1.ImageLocation = Application.StartupPath + "\\K-Bank.png";
                    btnATM.Enabled = true;
                }
                if(radioButton5.Checked == true)
                {
                    pictureBox1.ImageLocation = Application.StartupPath + "\\Bankkok_Bank.png";
                    btnATM.Enabled = true;
                }
                if (radioButton6.Checked == true)
                {
                    pictureBox1.ImageLocation = Application.StartupPath + "\\NEXT.png";
                    btnATM.Enabled = true;
                }
                if (radioButton7.Checked == true)
                {
                    pictureBox1.ImageLocation = Application.StartupPath + "\\KMA.jpg";
                    btnATM.Enabled = true;
                } 

           
        }
        int money = 0;                                                                                              //เงินที่เติมเข้ามา
        private void btnATM_Click(object sender, EventArgs e)
        {
            try
            {
                int x;
                x = Convert.ToInt32(txtaddmoney.Text);                                                              //code เติมเงินเข้าระบบ
                money += x;
                lblmoney.Text = money.ToString()+"B";
                lblmymoney.Text = money.ToString()+"B";
            }
            catch 
            {
                MessageBox.Show("กรุณาใส่จำนวนเงิน");
            }
        }
        int order = 0, vat7 = 0;

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Case
            int case1, order1;                                                                                      //code คำนวณแต่ละ Case
            case1 = Convert.ToInt32(txtCase1.Text);
            order1 = case1 * 5290;
            int case2, order2;
            case2 = Convert.ToInt32(txtCase2.Text);
            order2 = case2 * 2690;
            int case3, order3;
            case3 = Convert.ToInt32(txtCase3.Text);
            order3 = case3 * 1890;
            int case4, order4;
            case4 = Convert.ToInt32(txtCase4.Text);
            order4 = case4 * 2190;
            int case5, order5;
            case5 = Convert.ToInt32(txtCase5.Text);
            order5 = case5 * 1290;

            //CPU
            int CPU1, order6;                                                                                       //code คำนวณแต่ละ CPU
            CPU1 = Convert.ToInt32(txtCPU1.Text);
            order6 = CPU1 * 4890;
            int CPU2, order7;
            CPU2 = Convert.ToInt32(txtCPU2.Text);
            order7 = CPU2 * 13389;
            int CPU3, order8;
            CPU3 = Convert.ToInt32(txtCPU3.Text);
            order8 = CPU3 * 4690;
            int CPU4, order9;
            CPU4 = Convert.ToInt32(txtCPU4.Text);
            order9 = CPU4 * 7800;
            int CPU5, order10;
            CPU5 = Convert.ToInt32(txtCPU5.Text);
            order10 = CPU5 * 4970;

            //Graphic Card
            int Card1, order11;                                                                                     //code คำนวณแต่ละ Graphic Card
            Card1 = Convert.ToInt32(txtCard1.Text);
            order11 = Card1 * 10800;
            int Card2, order12;
            Card2 = Convert.ToInt32(txtCard2.Text);
            order12 = Card2 * 14500;
            int Card3, order13;
            Card3 = Convert.ToInt32(txtCard3.Text);
            order13 = Card3 * 4490;
            int Card4, order14;
            Card4 = Convert.ToInt32(txtCard4.Text);
            order14 = Card4 * 7990;
            int Card5, order15;
            Card5 = Convert.ToInt32(txtCard5.Text);
            order15 = Card5 * 8690;

            //HDD
            int HDD1, order16;                                                                                      //code คำนวณแต่ละ HDD
            HDD1 = Convert.ToInt32(txtHDD1.Text);
            order16 = HDD1 * 1750;
            int HDD2, order17;
            HDD2 = Convert.ToInt32(txtHDD2.Text);
            order17 = HDD2 * 1280;
            int HDD3, order18;
            HDD3 = Convert.ToInt32(txtHDD3.Text);
            order18 = HDD3 * 1467;
            int HDD4, order19;
            HDD4 = Convert.ToInt32(txtHDD4.Text);
            order19 = HDD4 * 2688;
            int HDD5, order20;
            HDD5 = Convert.ToInt32(txtHDD5.Text);
            order20 = HDD5 * 4250;

            //Keyboad
            int Keyboad1, order21;                                                                                  //code คำนวณแต่ละ Keyboad
            Keyboad1 = Convert.ToInt32(txtkeyboad1.Text);
            order21 = Keyboad1 * 6159;
            int Keyboad2, order22;
            Keyboad2 = Convert.ToInt32(txtkeyboad2.Text);
            order22 = Keyboad2 * 4590;
            int Keyboad3, order23;
            Keyboad3 = Convert.ToInt32(txtkeyboad3.Text);
            order23 = Keyboad3 * 2490;
            int Keyboad4, order24;
            Keyboad4 = Convert.ToInt32(txtkeyboad4.Text);
            order24 = Keyboad4 * 6790;
            int Keyboad5, order25;
            Keyboad5 = Convert.ToInt32(txtkeyboad5.Text);
            order25 = Keyboad5 * 1999;

            //Mainboad
            int Mainboad1, order26;                                                                                 //code คำนวณแต่ละ Mainboad
            Mainboad1 = Convert.ToInt32(txtMainboad1.Text);
            order26 = Mainboad1 * 6159;
            int Mainboad2, order27;
            Mainboad2 = Convert.ToInt32(txtMainboad2.Text);
            order27 = Mainboad2 * 4590;
            int Mainboad3, order28;
            Mainboad3 = Convert.ToInt32(txtMainboad3.Text);
            order28 = Mainboad3 * 2490;
            int Mainboad4, order29;
            Mainboad4 = Convert.ToInt32(txtMainboad4.Text);
            order29 = Mainboad4 * 6790;
            int Mainboad5, order30;
            Mainboad5 = Convert.ToInt32(txtMainboad5.Text);
            order30 = Mainboad5 * 1999;

            //Monitor
            int Monitor1, order31;                                                                                  //code คำนวณแต่ละ Monitor
            Monitor1 = Convert.ToInt32(txtMonitor1.Text);
            order31 = Monitor1 * 27570;
            int Monitor2, order32;
            Monitor2 = Convert.ToInt32(txtMonitor2.Text);
            order32 = Monitor2 * 6990;
            int Monitor3, order33;
            Monitor3 = Convert.ToInt32(txtMonitor3.Text);
            order33 = Monitor3 * 6959;
            int Monitor4, order34;
            Monitor4 = Convert.ToInt32(txtMonitor4.Text);
            order34 = Monitor4 * 44700;
            int Monitor5, order35;
            Monitor5 = Convert.ToInt32(txtMonitor5.Text);
            order35 = Monitor5 * 5150;

            //Mouse
            int Mouse1, order36;                                                                                    //code คำนวณแต่ละ Mouse
            Mouse1 = Convert.ToInt32(txtMouse1.Text);
            order36 = Mouse1 * 4990;
            int Mouse2, order37;
            Mouse2 = Convert.ToInt32(txtMouse2.Text);
            order37 = Mouse2 * 4490;
            int Mouse3, order38;
            Mouse3 = Convert.ToInt32(txtMouse3.Text);
            order38 = Mouse3 * 5590;
            int Mouse4, order39;
            Mouse4 = Convert.ToInt32(txtMouse4.Text);
            order39 = Mouse4 * 3990;
            int Mouse5, order40;
            Mouse5 = Convert.ToInt32(txtMouse5.Text);
            order40 = Mouse5 * 5290;

            //Power Supply
            int Supply1, order41;                                                                                   //code คำนวณแต่ละ Power Supply
            Supply1 = Convert.ToInt32(txtPSU1.Text);
            order41 = Supply1 * 1190;
            int Supply2, order42;
            Supply2 = Convert.ToInt32(txtPSU2.Text);
            order42 = Supply2 * 800;
            int Supply3, order43;
            Supply3 = Convert.ToInt32(txtPSU3.Text);
            order43 = Supply3 * 1090;
            int Supply4, order44;
            Supply4 = Convert.ToInt32(txtPSU4.Text);
            order44 = Supply4 * 2990;
            int Supply5, order45;
            Supply5 = Convert.ToInt32(txtPSU5.Text);
            order45 = Supply5 * 14900;

            //RAM
            int RAM1, order46;                                                                                      //code คำนวณแต่ละ RAM
            RAM1 = Convert.ToInt32(txtRAM1.Text);
            order46 = RAM1 * 1890;
            int RAM2, order47;
            RAM2 = Convert.ToInt32(txtRAM2.Text);
            order47 = RAM2 * 3690;
            int RAM3 , order48;
            RAM3 = Convert.ToInt32(txtRAM3.Text);
            order48 = RAM3 * 1890;
            int RAM4 , order49;
            RAM4 = Convert.ToInt32(txtRAM4.Text);
            order49 = RAM4 * 3690;
            int RAM5 , order50;
            RAM5 = Convert.ToInt32(txtRAM5.Text);
            order50 = RAM5 * 1790;

            //Storage
            int Storage1, order51;                                                                                  //code คำนวณแต่ละ Storage
            Storage1 = Convert.ToInt32(txtStorage1.Text);
            order51 = Storage1 * 2030;
            int Storage2, order52;
            Storage2 = Convert.ToInt32(txtStorage2.Text);
            order52 = Storage2 * 4990;
            int Storage3, order53;
            Storage3 = Convert.ToInt32(txtStorage3.Text);
            order53 = Storage3 * 2890;
            int Storage4, order54;
            Storage4 = Convert.ToInt32(txtStorage4.Text);
            order54 = Storage4 * 2390;
            int Storage5, order55;
            Storage5 = Convert.ToInt32(txtStorage5.Text);
            order55 = Storage5 * 4290;

            //total
            int total = 0;                                                                                          //code คำนวณสินค้าทั้งหมดที่ใส่ไป
            total = order1 + order2 + order3 + order4 + order5 + order5 + order6 + order7 + order8 + order9 + order10 + order11 + order12 + order13 + order14
                    + order15 + order16 + order17 + order18 + order19 + order20 + order21 + order22 + order23 + order24 + order25 + order26 + order27 + order28
                    + order29 + order30 + order31 + order32 + order33 + order34 + order35 + order36 + order37 + order38 + order39 + order40 + order41 + order42
                    + order43 + order44 + order45 + order46 + order47 + order48 + order49 + order50 + order51 + order52 + order53 + order54 + order55;
            order = total;
            lblorder.Text = order.ToString()+"B";
            lblorder2.Text = order.ToString()+"B";
            int vat;
            vat = total * 7 / 100;
            vat7 = vat;
            lblVAT.Text = vat7.ToString()+"B";
            btntotal.Enabled = true;
        }
        int CV = 0;

        private void btntotal_Click(object sender, EventArgs e)
        {
            int total2 = 0;                                                                                         //code คำนวณเงินในบัญชีลบด้วยราคาสินค้าที่รวมกับVat 7%
            total2 = (money + copot) - (order + vat7);
            if(order > 1000)
            {
                for (int i = 1; i <=order/100 ; i++) 
                {
                    CV++;                                                                                           // CV คือแต้มสะสมที่สามารถไปแลกส่วนลดได้
                }
            }
            if(money > order + vat7)
            {
                MessageBox.Show("การชำระเสร็จสิ้น");
                money = total2;
                lblmymoney.Text = total2.ToString()+"B";
            }
            else
            {
                MessageBox.Show("การชำระไม่สำเร็จ");
            }
            lbllastmoney.Text = total2.ToString()+"B";
            lblmark.Text = CV.ToString() +"  แต้ม";
            lblmark2.Text = CV.ToString()+"  แต้ม";
            if(CV > 150)                                                                                            //ถ้่า CV ถึง150 จะเปิดปุ่มแลกส่วนลด50บ.                 
            {
                btn50.Enabled = true;
            }
            if(CV > 300)                                                                                            //ถ้่า CV ถึง300 จะเปิดปุ่มแลกส่วนลด100บ.
            {
                btn100.Enabled = true;
            }
            if (CV > 450)                                                                                           //ถ้่า CV ถึง450 จะเปิดปุ่มแลกส่วนลด150บ.
            {
                btn150.Enabled = true;
            }
            if(CV > 600)                                                                                            //ถ้่า CV ถึง600 จะเปิดปุ่มแลกส่วนลด200บ.
            {
                btn200.Enabled = true;
            }
            if(CV > 750)                                                                                            //ถ้่า CV ถึง750 จะเปิดปุ่มแลกส่วนลด250บ.
            {
                btn250.Enabled = true;
            }
            if(CV > 1500)                                                                                           //ถ้่า CV ถึง1500 จะเปิดปุ่มแลกส่วนลด500บ.
            {
                btn500.Enabled = true;
            }
            if(CV > 2250)                                                                                           //ถ้่า CV ถึง2250 จะเปิดปุ่มแลกส่วนลด750บ.
            {
                btn750.Enabled = true;
            }
            if (CV >3000)                                                                                           //ถ้่า CV ถึง3000 จะเปิดปุ่มแลกส่วนลด1000บ.
            {
                btn1000.Enabled = true;
            }
        }
        int copot = 0;                                                                                              //copot คือ จำนวณเงินที่แลกจากส่วนลด                                         

        private void btn50_Click(object sender, EventArgs e)
        {
            int x = 50;                                                                                             //ถ้่าแลกส่วนลด50 CVจะลบ150ทุกครั้งที่กดและส่งค่าcopotไปที่คำนวณสินค้า
            if (CV > 150)
            {
                copot += x;
                CV -= 150;
                lblmark.Text = CV.ToString() + "  แต้ม";
                lblmark2.Text = CV.ToString() + "  แต้ม";
                lblcoupon.Text = copot.ToString() + "B";
            }
            if (CV < 150)                                                                                           //ถ้่า CV ไม่ถึง150 ปุ่ม50จะปิด
            {
                btn50.Enabled = false;
            }
            if (CV < 300)                                                                                           //ถ้่า CV ไม่ถึง300 ปุ่ม100จะปิด
            {
                btn100.Enabled = false;
            }
            if (CV < 450)                                                                                           //ถ้่า CV ไม่ถึง450 ปุ่ม150จะปิด
            {
                btn150.Enabled = false;
            }
            if (CV < 600)                                                                                           //ถ้่า CV ไม่ถึง600 ปุ่ม200จะปิด
            {
                btn200.Enabled = false;
            }
            if (CV < 750)                                                                                           //ถ้่า CV ไม่ถึง750 ปุ่ม250จะปิด
            {
                btn250.Enabled = false;
            }
            if (CV < 1500)                                                                                          //ถ้่า CV ไม่ถึง1500 ปุ่ม500จะปิด
            {
                btn500.Enabled = false;
            }
            if (CV < 2250)                                                                                          //ถ้่า CV ไม่ถึง2250 ปุ่ม750จะปิด
            {
                btn750.Enabled = false;
            }
            if (CV < 3000)                                                                                          //ถ้่า CV ไม่ถึง3000 ปุ่ม1000จะปิด
            {
                btn1000.Enabled = false;
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            int x = 100;                                                                                            //ถ้่าแลกส่วนลด100 CVจะลบ300ทุกครั้งที่กดและส่งค่าcopotไปที่คำนวณสินค้า
            if (CV > 300)
            {
                copot += x;
                CV -= 300;
                lblmark.Text = CV.ToString() + "  แต้ม";
                lblmark2.Text = CV.ToString() + "  แต้ม";
                lblcoupon.Text = copot.ToString() + "B";
            }
            if (CV < 150)
            {
                btn50.Enabled = false;
            }
            if (CV < 300)
            {
                btn100.Enabled = false;
            }
            if (CV < 450)
            {
                btn150.Enabled = false;
            }
            if (CV < 600)
            {
                btn200.Enabled = false;
            }
            if (CV < 750)
            {
                btn250.Enabled = false;
            }
            if (CV < 1500)
            {
                btn500.Enabled = false;
            }
            if (CV < 2250)
            {
                btn750.Enabled = false;
            }
            if (CV < 3000)
            {
                btn1000.Enabled = false;
            }

        }

        private void btn150_Click(object sender, EventArgs e)
        {
            int x = 150;                                                                                            //ถ้่าแลกส่วนลด150 CVจะลบ450ทุกครั้งที่กดและส่งค่าcopotไปที่คำนวณสินค้า
            if (CV > 450)
            {
                copot += x;
                CV -= 450;
                lblmark.Text = CV.ToString() + "  แต้ม";
                lblmark2.Text = CV.ToString() + "  แต้ม";
                lblcoupon.Text = copot.ToString() + "B";
            }
            if (CV < 150)
            {
                btn50.Enabled = false;
            }
            if (CV < 300)
            {
                btn100.Enabled = false;
            }
            if (CV < 450)
            {
                btn150.Enabled = false;
            }
            if (CV < 600)
            {
                btn200.Enabled = false;
            }
            if (CV < 750)
            {
                btn250.Enabled = false;
            }
            if (CV < 1500)
            {
                btn500.Enabled = false;
            }
            if (CV < 2250)
            {
                btn750.Enabled = false;
            }
            if (CV < 3000)
            {
                btn1000.Enabled = false;
            }
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            int x = 200;                                                                                            //ถ้่าแลกส่วนลด200 CVจะลบ600ทุกครั้งที่กดและส่งค่าcopotไปที่คำนวณสินค้า
            if (CV > 600)
            {
                copot += x;
                CV -= 600;
                lblmark.Text = CV.ToString() + "  แต้ม";
                lblmark2.Text = CV.ToString() + "  แต้ม";
                lblcoupon.Text = copot.ToString() + "B";
            }
            if (CV < 150)
            {
                btn50.Enabled = false;
            }
            if (CV < 300)
            {
                btn100.Enabled = false;
            }
            if (CV < 450)
            {
                btn150.Enabled = false;
            }
            if (CV < 600)
            {
                btn200.Enabled = false;
            }
            if (CV < 750)
            {
                btn250.Enabled = false;
            }
            if (CV < 1500)
            {
                btn500.Enabled = false;
            }
            if (CV < 2250)
            {
                btn750.Enabled = false;
            }
            if (CV < 3000)
            {
                btn1000.Enabled = false;
            }
        }

        private void btn250_Click(object sender, EventArgs e)
        {
            int x = 250;                                                                                            //ถ้่าแลกส่วนลด250 CVจะลบ750ทุกครั้งที่กดและส่งค่าcopotไปที่คำนวณสินค้า
            if (CV > 750)
            {
                copot += x;
                CV -= 750;
                lblmark.Text = CV.ToString() + "  แต้ม";
                lblmark2.Text = CV.ToString() + "  แต้ม";
                lblcoupon.Text = copot.ToString() + "B";
            }
            if (CV < 150)
            {
                btn50.Enabled = false;
            }
            if (CV < 300)
            {
                btn100.Enabled = false;
            }
            if (CV < 450)
            {
                btn150.Enabled = false;
            }
            if (CV < 600)
            {
                btn200.Enabled = false;
            }
            if (CV < 750)
            {
                btn250.Enabled = false;
            }
            if (CV < 1500)
            {
                btn500.Enabled = false;
            }
            if (CV < 2250)
            {
                btn750.Enabled = false;
            }
            if (CV < 3000)
            {
                btn1000.Enabled = false;
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            int x = 500;                                                                                            //ถ้่าแลกส่วนลด500 CVจะลบ1500ทุกครั้งที่กดและส่งค่าcopotไปที่คำนวณสินค้า
            if (CV > 1500)
            {
                copot += x;
                CV -= 1500;
                lblmark.Text = CV.ToString() + "  แต้ม";
                lblmark2.Text = CV.ToString() + "  แต้ม";
                lblcoupon.Text = copot.ToString() + "B";
            }
            if (CV < 150)
            {
                btn50.Enabled = false;
            }
            if (CV < 300)
            {
                btn100.Enabled = false;
            }
            if (CV < 450)
            {
                btn150.Enabled = false;
            }
            if (CV < 600)
            {
                btn200.Enabled = false;
            }
            if (CV < 750)
            {
                btn250.Enabled = false;
            }
            if (CV < 1500)
            {
                btn500.Enabled = false;
            }
            if (CV < 2250)
            {
                btn750.Enabled = false;
            }
            if (CV < 3000)
            {
                btn1000.Enabled = false;
            }
        }

        private void btn750_Click(object sender, EventArgs e)
        {
            int x = 750;                                                                                            //ถ้่าแลกส่วนลด750 CVจะลบ2250ทุกครั้งที่กดและส่งค่าcopotไปที่คำนวณสินค้า
            if (CV > 2250)
            {
                copot += x;
                CV -= 2550;
                lblmark.Text = CV.ToString() + "  แต้ม";
                lblmark2.Text = CV.ToString() + "  แต้ม";
                lblcoupon.Text = copot.ToString() + "B";
            }
            if (CV < 150)
            {
                btn50.Enabled = false;
            }
            if (CV < 300)
            {
                btn100.Enabled = false;
            }
            if (CV < 450)
            {
                btn150.Enabled = false;
            }
            if (CV < 600)
            {
                btn200.Enabled = false;
            }
            if (CV < 750)
            {
                btn250.Enabled = false;
            }
            if (CV < 1500)
            {
                btn500.Enabled = false;
            }
            if (CV < 2250)
            {
                btn750.Enabled = false;
            }
            if (CV < 3000)
            {
                btn1000.Enabled = false;
            }
        }
        private void btn1000_Click(object sender, EventArgs e)
        {
            int x = 1000;                                                                                           //ถ้่าแลกส่วนลด1000 CVจะลบ3000ทุกครั้งที่กดและส่งค่าcopotไปที่คำนวณสินค้า
            if (CV > 3000)
            {
                copot += x;
                CV -= 3000;
                lblmark.Text = CV.ToString() + "  แต้ม";
                lblmark2.Text = CV.ToString() + "  แต้ม";
                lblcoupon.Text = copot.ToString() + "B";
            }
            if (CV < 150)
            {
                btn50.Enabled = false;
            }
            if (CV < 300)
            {
                btn100.Enabled = false;
            }
            if (CV < 450)
            {
                btn150.Enabled = false;
            }
            if (CV < 600)
            {
                btn200.Enabled = false;
            }
            if (CV < 750)
            {
                btn250.Enabled = false;
            }
            if (CV < 1500)
            {
                btn500.Enabled = false;
            }
            if (CV < 2250)
            {
                btn750.Enabled = false;
            }
            if (CV < 3000)
            {
                btn1000.Enabled = false;
            }
        }

    }
}
