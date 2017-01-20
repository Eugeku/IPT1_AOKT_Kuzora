using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IPT1_AOKT_Kuzora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var encoding = Encoding.GetEncoding(1251);
                FileStream outputStream = new FileStream("outputKuzora.bin", FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(outputStream);
                bw.Write(new byte[] { 27, (byte)'@'}); //сброс
                bw.Write(new byte[] { 27, (byte)'M' }); //шрифт элит
                bw.Write(new byte[] { 27, 108, 6}); //установка h1=1,5 см
                bw.Write(encoding.GetBytes("МИНИСТЕРСТВО ОБРАЗОВАНИЯ РЕСПУБЛИКИ БЕЛАРУСЬ\r\n\r\n")); //печать строки 
                bw.Write(new byte[] { 27, 51, 200 }); // отступ h2
                bw.Write(new byte[] { 27, 87, 1 }); // вкл режима дв ширины
                bw.Write(new byte[] { 27, 108, 23 }); // отступ от начала строки
                bw.Write(encoding.GetBytes("БГУИР\r\n")); //печать строки
                bw.Write(new byte[] { 27, 87, 0 }); //откл режима дв ширины
                bw.Write(new byte[] { 27, (byte)'@' }); //сброс
                bw.Write(encoding.GetBytes("\r\n"));
                bw.Write(new byte[] { 27, 38, 0, (byte)'!', (byte)'!' });//выбираю последовательность, которую хочу изменить
                //ОПРЕДЕЛЕНИЕ ЗНАКА ПОЛЬЗОВАТЕЛЯ
                bw.Write(new byte[] { 0, 2, 5, 5, 2, 252, 2, 0, 0, 1, 1, 0 });
                for (int i = 1; i <= 50; ++i)
                    bw.Write(new byte[] { 27, 37, 1, (byte)'!' });
                bw.Write(new byte[] { 27, (byte)'@' });
                bw.Write(new byte[] { 27, 87, 1 }); // вкл режима дв ширины
                bw.Write(new byte[] { 27, 108, 20 }); //отступ
                bw.Write(encoding.GetBytes("ОТЧЕТ\r\n")); //печать строки
                bw.Write(new byte[] { 27, 87, 0 }); //откл режима дв ширины
                bw.Write(new byte[] { 27, (byte)'@' });
                bw.Write(new byte[] { 27, 51, 100 }); // отступ h3
                bw.Write(new byte[] { 27, (byte)'X', 1 }); // вкл качетсвенного режима печати
                bw.Write(new byte[] { 27, 108, 15 }); //гор отступ
                bw.Write(encoding.GetBytes("ПО ЛАБОРАТОРНОЙ РАБОТЕ №6\r\n"));
                bw.Write(new byte[] { 27, (byte)'X', 0 }); // выкл качетсвенного режима печати
                bw.Write(new byte[] { 27, (byte)'@' }); //сброс
                bw.Write(new byte[] { 27, 108, 19 }); //отступ
                //bw.Write(new byte[] { 27, (byte)'p', 1}); // вкл рспред режима печати
                bw.Write(new byte[] { 27, 51, 250 }); //верт отступ h4
                bw.Write(encoding.GetBytes("КУРС - ПУ ЭВМ\r\n")); //печать строки
                // bw.Write(new byte[] { 27, (byte)'p', 0 }); //выкл рспред режима печати
                bw.Write(new byte[] { 27, 51, 40 }); //верт отступ
                bw.Write(new byte[] { 27, (byte)'@' ,27, (byte)'P' }); //шрифт пайк
                bw.Write(encoding.GetBytes("Студент"));
                bw.Write(new byte[] { 27, 36, 100, 0 }); //гор отступ h5
                bw.Write(encoding.GetBytes("Проверил\r\n"));
                bw.Write(new byte[] { 27, (byte)'@' }); //сброс
                bw.Write(new byte[] { 27, (byte)'E' }); //акцентированная печать
                bw.Write(new byte[] { 27, 51, 250 }); //верт отступ
                bw.Write(encoding.GetBytes("КУЗОРА Е.А."));
                bw.Write(new byte[] { 27, 36, 100, 0 }); //гор отступ h5
                bw.Write(new byte[] { 27, 45, 1}); //вкл подчеркивание
                bw.Write(encoding.GetBytes("ФАДЕЕВ Е.П.\r\n"));
                bw.Write(new byte[] { 27, 45, 0 }); //выкл подчеркивание
                bw.Write(new byte[] { 27, (byte)'@' }); //сброс
                bw.Write(new byte[] { 27, 36, 30, 0 });
                bw.Write(new byte[] { 27, (byte)'K', 60, 0 }); //граф режим
                for (int i = 1; i <= 5; ++i)
                    bw.Write(new byte[] { 255, 129, 129, 255, 129, 129, 255, 129, 129, 255, 129, 129 });
                bw.Write(new byte[] { 27, 51, 100 });
                bw.Write(encoding.GetBytes("\r\n"));
                bw.Write(new byte[] { 27, (byte)'X', 1 }); // вкл качетсвенного режима печати
                bw.Write(new byte[] { 27, 108, 23 }); // гор отступ
                bw.Write(new byte[] { 27, 51, 50 });
                bw.Write(encoding.GetBytes("МИНСК\r\n"));
                bw.Write(new byte[] { 27, (byte)'X', 0 }); // выкл качетсвенного режима печати
                bw.Write(new byte[] { 27, (byte)'@' }); //сброс
                bw.Write(new byte[] { 27, 87, 1 }); // вкл режима дв ширины
                bw.Write(new byte[] { 27, 108, 21 }); // отступ от начала строки
                bw.Write(encoding.GetBytes("2017")); //печать строки
                bw.Write(new byte[] { 27, 87, 0 }); //откл режима дв ширины
                bw.Close();
            }
            catch (IOException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
