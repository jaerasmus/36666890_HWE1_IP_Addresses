# 36666890_HWE1_IP_Addresses
Jan-Albert Erasmus
36666890

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

        This piece of code converts a decimal (integer) value into a sequence of binary numbers that will be used for IP-addresses. I coded this piece of code for IP-address calculation in a network environment.