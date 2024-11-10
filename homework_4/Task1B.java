// Task1B


    public class Task1B
    {
        public static void main(String[] args)
        {

            int num = 10;
            if (num == 10) // 1st if
            {
                num = 5;
                System.out.println("Num is = " + num);
            } 
            
            
            else { //1st if and nest the second if else block
                if (num == 10) //2nd if
                {
                    num = 15;
                    System.out.println("Num is = " + num);

                }
                else //2nd else
                {
                    num = 30;
                    System.out.println("Num is = " + num);

                }
            }

        }
    }