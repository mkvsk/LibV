namespace LibV
{    //x.x.x
    public class Version
    {
        readonly string userIsARat = "Invalid data. Try again: ";
        public void CheckStr(string currentV, string otherV)
        {
            bool res = false;
            ulong tmp1;
            ulong tmp2;
            string[] currentArr;
            string[] otherArr;
            
            try
            {
                currentArr = currentV.Split(('.'), StringSplitOptions.RemoveEmptyEntries);
                otherArr = otherV.Split(('.'), StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        if (i == j)
                        {
                            tmp1 = ulong.Parse(currentArr[i]);
                            tmp2 = ulong.Parse(otherArr[j]);


                            if (tmp1 < tmp2)
                            {
                                res = true;
                            }
                            if (tmp1 >= tmp2)
                            {
                                res = false;
                            }
                        }
                    }
                }
                Result(res);
            }
            catch (InvalidDataException)
            {
                Console.WriteLine(userIsARat);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(userIsARat);
            }
            catch (FormatException)
            {
                Console.WriteLine(userIsARat);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine(userIsARat);
            }
            catch (OverflowException)
            {
                Console.WriteLine(userIsARat);
            }

        }

        public void Result(bool res)
        {
            if (res)
            {
                Console.WriteLine("Obnovi");
            }
            if (!res)
            {
                Console.WriteLine("ne nado obnovlyat");
            }

        }
       
    }
}