using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Calculator
{
    public partial class frmIPCalculator : Form
    {
        private int ButtonWidth = 0;
        private int ButtonYPos = 0;

        public frmIPCalculator()
        {
            InitializeComponent();

            Width = 717;
            Height = 600;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.Teal;

            MaximizeBox = false;
        }

        //Methods
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        private void displayCol()
        {
            lbxOutput.Items.Clear();
            lbxOutput.Items.Clear();
            lbxOutput.Items.Add("Criteria\t\t\t\t\t" + "Addresses & Other Information");
            lbxOutput.Items.Add("===============================================================================================");
        }

        private string removeChar(char Character, string Str)
        {
            string NewStr = "";

            for (int k = 0; k < Str.Length; ++k)
            {
                if (Str[k] != Character)
                {
                    NewStr += Str[k];
                }
            }

            return NewStr;
        }

        private int Pos(char Character, string Str)
        {
            int Position = 0;

            for (int k = 0; k < Str.Length; ++k)
            {
                if (Character == Str[k])
                {
                    Position = k;
                    break;
                }
            }

            return Position;
        }

        private string Copy(string Str, int Pos)
        {
            string CopyStr = "";

            for (int k = 0; k <= Str.Length; ++k)
            {
                if (k <= Pos)
                {
                    CopyStr += Str[k];
                }
            }

            return CopyStr;
        }

        private string Copy(string Str, int StartPos, int Pos)
        {
            string CopyStr = "";

            for (int k = StartPos; k <= Str.Length; ++k)
            {
                if (k <= Pos)
                {
                    CopyStr += Str[k];
                }
            }

            return CopyStr;
        }

        private string Delete(string Str, int Pos)
        {
            string CopyStr = "";

            for (int k = 0; k < Str.Length; ++k)
            {
                if (k > Pos)
                {
                    CopyStr += Str[k];
                }
            }

            return CopyStr;
        }

        private string Delete(string Str, int StartPos, int Pos)
        {
            string CopyStr = "";

            for (int k = StartPos; k < Str.Length; ++k)
            {
                if (k > Pos)
                {
                    CopyStr += Str[k];
                }
            }

            return CopyStr;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        //Decimal to Binary Converter
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        private string DecToBin(int Number)
        {
            string BinaryNum = "";

            int iCount = 0;

            double TempNum = 0;

            if (Number == 0)
                return "00000000";
            else
            {
                TempNum = Number;

                while (TempNum > 0)
                {
                    if (TempNum % 2 == 0)
                    {
                        BinaryNum = '0' + BinaryNum;
                    }

                    TempNum = TempNum / 2;
                    TempNum = Math.Truncate(TempNum);

                    if (TempNum % 2 == 1)
                    {
                        BinaryNum = "1" + BinaryNum;
                    }
                }

                for (int k = 0; k < BinaryNum.Length; ++k)
                    iCount += 1;

                switch (iCount)
                {
                    case 1:
                        {
                            BinaryNum = "0000000" + BinaryNum;
                            break;
                        }
                    case 2:
                        {
                            BinaryNum = "000000" + BinaryNum;
                            break;
                        }
                    case 3:
                        {
                            BinaryNum = "00000" + BinaryNum;
                            break;
                        }
                    case 4:
                        {
                            BinaryNum = "0000" + BinaryNum;
                            break;
                        }
                    case 5:
                        {
                            BinaryNum = "000" + BinaryNum;
                            break;
                        }
                    case 6:
                        {
                            BinaryNum = "00" + BinaryNum;
                            break;
                        }
                    case 7:
                        {
                            BinaryNum = "0" + BinaryNum;
                            break;
                        }
                }

                return BinaryNum;
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        //Binary to Decimal Converter
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        private int BinToDec(string Binary)
        {
            //128 + 64 + 32 + 16 + 8 + 4 + 2 + 1
            //x7  + x6 + x5 + x4 + x3 + x2 + x1 + x0

            int DecNum = 0;

            for (int k = 0; k < Binary.Length; ++k)
            {
                switch (k)
                {
                    case 0:
                        {
                            if (Binary[k] == '1')
                                DecNum += 128;
                            else 
                                DecNum += 0;
                            break;
                        }
                    case 1:
                        {
                            if (Binary[k] == '1')
                                DecNum += 64;
                            else
                                DecNum += 0;
                            break;
                        }
                    case 2:
                        {
                            if (Binary[k] == '1')
                                DecNum += 32;
                            else
                                DecNum += 0;
                            break;
                        }
                    case 3:
                        {
                            if (Binary[k] == '1')
                                DecNum += 16;
                            else
                                DecNum += 0;
                            break;
                        }
                    case 4:
                        {
                            if (Binary[k] == '1')
                                DecNum += 8;
                            else
                                DecNum += 0;
                            break;
                        }
                    case 5:
                        {
                            if (Binary[k] == '1')
                                DecNum += 4;
                            else
                                DecNum += 0;
                            break;
                        }
                    case 6:
                        {
                            if (Binary[k] == '1')
                                DecNum += 2;
                            else
                                DecNum += 0;
                            break;
                        }
                    case 7:
                        {
                            if (Binary[k] == '1')
                                DecNum += 1;
                            else
                                DecNum += 0;
                            break;
                        }
                }
            }

            return DecNum;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        private void frmIPCalculator_Load(object sender, EventArgs e)
        {
            //Select Network Type
            gbxSelectIPType.Size = new Size(200, 100);
            gbxSelectIPType.Location = new Point(10, 10);
            gbxSelectIPType.BackColor = Color.MediumPurple;
            gbxSelectIPType.ForeColor = Color.White;
            gbxSelectIPType.Text = "Select an Network type:";

            rbnClassful.Text = "&Classful";
            rbnClassful.Location = new Point(10, 30);

            rbnClassless.Text = "C&lassless";
            rbnClassless.Location = new Point(10, 60);

            //Number of Devices in Network
            gbxNumDevices.Size = new Size(gbxSelectIPType.Width, gbxSelectIPType.Height);
            gbxNumDevices.Location = new Point((gbxSelectIPType.Width + 50), 10);
            gbxNumDevices.BackColor = Color.MediumPurple;
            gbxNumDevices.ForeColor = Color.White;
            gbxNumDevices.Text = "Enter number of devices:";

            txtNumAddresses.Size = new Size(150, 20);
            txtNumAddresses.Location = new Point(10, 40);
            txtNumAddresses.ForeColor = Color.Black;

            //IP Address in Network
            gbxIPAddress.Size = new Size(gbxSelectIPType.Width, gbxSelectIPType.Height);
            gbxIPAddress.Location = new Point((gbxSelectIPType.Width + gbxNumDevices.Width + 90), 10);
            gbxIPAddress.BackColor = Color.MediumPurple;
            gbxIPAddress.ForeColor = Color.White;
            gbxIPAddress.Text = "Enter a network address:";

            txtAddress.Size = new Size(150, 20);
            txtAddress.Location = new Point(10, 40);
            txtAddress.ForeColor = Color.Black;

            //Button calculate
            ButtonWidth = gbxSelectIPType.Width + gbxNumDevices.Width + gbxIPAddress.Width + 80;
            ButtonYPos = gbxSelectIPType.Height + 20;

            btnCalculate.Size = new Size(ButtonWidth, 50);
            btnCalculate.Location = new Point(gbxSelectIPType.Location.X, ButtonYPos);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.BackColor = Color.DarkBlue;
            btnCalculate.Text = "&Calculate";

            //ListBox - Output
            lbxOutput.Size = new Size(ButtonWidth, 350);
            lbxOutput.Location = new Point(btnCalculate.Location.X, ButtonYPos + btnCalculate.Height + 10);
            displayCol();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variable declarations
            displayCol();

            char cType = ' ';

            string sNetType = "";

            string sIPAddress = "";
            string sPart1 = "";
            string sPart2 = "";
            string sPart3 = "";
            string sPart4 = "";
            string sTemp = "";

            string sClass = "";
            string sSubnetMask = "";
            string sBinSubnet = "";

            string sNetworkIP = "";
            string sBroadcastIP = "";
            string sSmallestIP = "";
            string sLargestIP = "";

            int iNumAddresses = 0;

            int iPos = 0;
            int iNum0 = 0;
            int iBin_Rest_Num = 0;

            int iCount = 0;

            double iTemp = 0.0;

            //INPUT
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (rbnClassful.Checked)
            {
                sNetType = rbnClassful.Text;
                sNetType = removeChar('&', sNetType);
                cType = 'F';
            }

            if (rbnClassless.Checked)
            {
                sNetType = rbnClassless.Text;
                sNetType = removeChar('&', sNetType);
                cType = 'L';
            }

            if (int.TryParse(txtNumAddresses.Text, out iNumAddresses) == false)
            {
                MessageBox.Show("Please enter a valid field");
                txtNumAddresses.Clear();
                txtNumAddresses.Focus();
            }

            iNumAddresses += 2;

            sIPAddress = txtAddress.Text;
            sTemp = sIPAddress;

            if ((sIPAddress == "") || (sIPAddress.Contains('.') == false))
            {
                MessageBox.Show("Please enter a valid address");
                txtAddress.Clear();
                txtAddress.Focus();
            }
            else
            {
                iPos = Pos('.', sTemp);
                sPart1 = Copy(sTemp, 0, iPos - 1);
                sTemp = Delete(sTemp, iPos);

                iPos = Pos('.', sTemp);
                sPart2 = Copy(sTemp, iPos - 1);
                sTemp = Delete(sTemp, 0, iPos);

                iPos = Pos('.', sTemp);
                sPart3 = Copy(sTemp, 0, iPos - 1);
                sTemp = Delete(sTemp, iPos);

                sPart4 = sTemp;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////

            //PROCESSING
            ////////////////////////////////////////////////////////////////////////////////////////////

            //CLASSFUL
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (cType == 'F')
            {
                //Class A - 16 777 216 (1 to 127)
                //Class B - 65 536     (128 to 191)
                //Class C - 256        (192 to 223)

                if ((iNumAddresses <= 256) && ((int.Parse(sPart1) > 191) && (int.Parse(sPart1) <= 223)))
                {
                    //Binary Subnet: 111111111.11111111.11111111.00000000
                    sClass = "Class C";
                    sSubnetMask = "255.255.255.0";
                    sNetworkIP = sPart1 + '.' + sPart2 + '.' + sPart3 + ".0";
                    sBroadcastIP = sPart1 + '.' + sPart2 + '.' + sPart3 + ".255";
                    sSmallestIP = sPart1 + '.' + sPart2 + '.' + sPart3 + '.' + (0 + 1).ToString();
                    sLargestIP = sPart1 + '.' + sPart2 + '.' + sPart3 + '.' + (255 - 1).ToString();
                }
                else if ((iNumAddresses <= 65536) && ((int.Parse(sPart1) > 127) && (int.Parse(sPart1) <= 191)))
                {
                    //Binary Subnet: 111111111.11111111.00000000.00000000
                    sClass = "Class B";
                    sSubnetMask = "255.255.0.0";
                    sNetworkIP = sPart1 + '.' + sPart2 + ".0.0";
                    sBroadcastIP = sPart1 + '.' + sPart2 + ".255.255";
                    sSmallestIP = sPart1 + '.' + sPart2 + ".0" + '.' + (0 + 1).ToString();
                    sLargestIP = sPart1 + '.' + sPart2 + ".255" + '.' + (255 - 1).ToString();
                }
                else if ((iNumAddresses <= 16777216) && ((int.Parse(sPart1) >= 1) && (int.Parse(sPart1) <= 127)))
                {
                    //Binary Subnet: 111111111.00000000.00000000.00000000
                    sClass = "Class A";
                    sSubnetMask = "255.0.0.0";
                    sNetworkIP = sPart1 + ".0.0.0";
                    sBroadcastIP = sPart1 + ".255.255.255";
                    sSmallestIP = sPart1 + '.' + ".0.0." + (0 + 1).ToString();
                    sLargestIP = sPart1 + ".255.255." + (255 - 1).ToString();
                }
                else
                    sClass = "Invalid";
            }
            ////////////////////////////////////////////////////////////////////////////////////////////

            //CLASSLESS
            ////////////////////////////////////////////////////////////////////////////////////////////
            if (cType == 'L')
            {
                //24 is MAX # of 0's that can be added to the Subnet Mask
                for (int k = 1; k <= 24; ++k)
                {
                    if (Math.Pow(2, k) >= iNumAddresses)
                    {
                        iNum0 = k;
                        break;
                    }
                }

                iBin_Rest_Num = 32 - iNum0;

                for (int k = 1; k <= 32; ++k)
                {
                    if (k <= iBin_Rest_Num)
                    {
                        if (k == 9)
                            sBinSubnet += '.';
                        else if (k == 17)
                            sBinSubnet += '.';
                        else if (k == 25)
                            sBinSubnet += '.';

                        sBinSubnet += '1';
                    }
                    else
                    {
                        if (k == 17)
                            sBinSubnet += '.';
                        else if (k == 25)
                            sBinSubnet += '.';

                        sBinSubnet += '0';
                    }
                }

                sTemp = sBinSubnet;

                iPos = Pos('.', sTemp);
                sPart1 = Copy(sTemp, iPos - 1);
                sTemp = Delete(sTemp, 0, iPos);
                sSubnetMask += BinToDec(sPart1).ToString() + '.';

                iPos = Pos('.', sTemp);
                sPart2 = Copy(sTemp, 0, iPos - 1);
                sTemp = Delete(sTemp, iPos);
                sSubnetMask += BinToDec(sPart2).ToString() + '.';

                iPos = Pos('.', sTemp);
                sPart3 = Copy(sTemp, iPos - 1);
                sTemp = Delete(sTemp, 0, iPos);
                sSubnetMask += BinToDec(sPart3).ToString() + '.';

                sPart4 = sTemp;
                sSubnetMask += BinToDec(sPart4).ToString();

                while (iTemp <= iNumAddresses)
                {
                    iTemp = Math.Pow(2, iCount);

                    iCount += 1;
                }

                sTemp = sIPAddress;

                iPos = Pos('.', sTemp);
                sPart1 = Copy(sTemp, iPos - 1);
                sTemp = Delete(sTemp, 0, iPos);

                iPos = Pos('.', sTemp);
                sPart2 = Copy(sTemp, 0, iPos - 1);
                sTemp = Delete(sTemp, iPos);

                iPos = Pos('.', sTemp);
                sPart3 = Copy(sTemp, iPos - 1);
                sTemp = Delete(sTemp, 0, iPos);

                sPart4 = sTemp;

                switch (iCount)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    case 8:
                        {
                            break;
                        }
                    case 9:
                        {
                            sTemp = DecToBin(int.Parse(sPart1)) + '.' + DecToBin(int.Parse(sPart2)) + '.' + DecToBin(int.Parse(sPart3)) + '.' + DecToBin(int.Parse(sPart4));

                            break;
                        }
                    case 10:
                        {
                            break;
                        }
                    case 11:
                        {
                            break;
                        }
                    case 12:
                        {
                            break;
                        }
                    case 13:
                        {
                            break;
                        }
                    case 14:
                        {
                            break;
                        }
                    case 15:
                        {
                            break;
                        }
                    case 16:
                        {
                            break;
                        }
                    case 17:
                        {
                            break;
                        }
                    case 18:
                        {
                            break;
                        }
                    case 19:
                        {
                            break;
                        }
                    case 20:
                        {
                            break;
                        }
                    case 21:
                        {
                            break;
                        }
                    case 22:
                        {
                            break;
                        }
                    case 23:
                        {
                            break;
                        }
                    case 24:
                        {
                            break;
                        }
                }
            }
            ////////////////////////////////////////////////////////////////////////////////////////////

            //OUTPUT
            ////////////////////////////////////////////////////////////////////////////////////////////
            lbxOutput.Items.Add("Network Type:\t\t\t\t" + sNetType);
            
            if (cType == 'F')
                lbxOutput.Items.Add("Network Class:\t\t\t\t" + sClass);

            lbxOutput.Items.Add("Number of Devices:\t\t\t\t" + (iNumAddresses - 2).ToString());
            lbxOutput.Items.Add("Given IP-Address:\t\t\t\t" + sIPAddress);
            lbxOutput.Items.Add("");
            lbxOutput.Items.Add("===============================================================================================");
            lbxOutput.Items.Add("Subnet mask:\t\t\t\t" + sSubnetMask);
            lbxOutput.Items.Add("Network IP:\t\t\t\t" + sNetworkIP);
            lbxOutput.Items.Add("Broadcast IP:\t\t\t\t" + sBroadcastIP);
            lbxOutput.Items.Add("Smallest IP:\t\t\t\t" + sSmallestIP);
            lbxOutput.Items.Add("Largest IP:\t\t\t\t\t" + sLargestIP);
            lbxOutput.Items.Add("Router IP:\t\t\t\t\t" + sSmallestIP + " OR " + sLargestIP);
            ////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
