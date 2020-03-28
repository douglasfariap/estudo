using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CataProcesso {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre a Matricula do Funcionário: ");
            int mat = int.Parse(Console.ReadLine());            
            Funcionarios fun = new Funcionarios(mat);
            fun.matricula = mat;

            //____________Criar Diretorio na area de trabalho_________________________
            String targetPath =Directory.GetCurrentDirectory() + @"\" + fun.BuscaNomeFunc(fun.matricula);  
            Console.WriteLine(targetPath);
            System.IO.Directory.CreateDirectory(targetPath);

            //************************************COPIAR FR************************************************
            String sourcePatch = @"C:\Users\Douglas\Desktop\AD\Ficha_Registro";
            String fileName = fun.BuscaFR(fun.matricula);
            String sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            String destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //************************************COPIAR TR************************************************
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\TRCT";
            fileName = fun.BuscaTRCT(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //************************************COPIAR FGTS ITPLAN************************************************
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\FGTS\ITPLAN";
            fileName = fun.BuscaFGTSItplan(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //************************************COPIAR FGTS Probid************************************************
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\FGTS\PROBID";
            fileName = fun.BuscaFGTSProbid(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //************************************COPIAR CT************************************************
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contratos de Trabalho";
            fileName = fun.BuscaCT(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            //************************************COPIAR AA************************************************
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\ASO\Aso_Admissional";
            fileName = fun.BuscaAA(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }

            //************************************COPIAR AD************************************************
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\ASO\Aso_Demissional";
            fileName = fun.BuscaAD(fun.matricula);
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            Console.WriteLine(fun.nomehl[0]);
            //************************************COPIAR HLs************************************************
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2017\11 - Novembro";
            fileName =fun.nomehl[0] ;
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2017\12 - Dezembro";
            fileName = fun.nomehl[1];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2017\13 - Décimo";
            fileName = fun.nomehl[2];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\01 - Janeiro";
            fileName = fun.nomehl[3];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\02 - Fevereiro";
            fileName = fun.nomehl[4];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\03 - Março";
            fileName = fun.nomehl[5];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\04 - Abril";
            fileName = fun.nomehl[6];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\05 - Maio";
            fileName = fun.nomehl[7];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\06 - Junho";
            fileName = fun.nomehl[8];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\07 - Julho";
            fileName = fun.nomehl[9];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\08 - Agosto";
            fileName = fun.nomehl[10];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\09 - Setembro";
            fileName = fun.nomehl[11];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\10 - Outubro";
            fileName = fun.nomehl[12];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\11 - Novembro";
            fileName = fun.nomehl[13];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\12 - Dezembro";
            fileName = fun.nomehl[14];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2018\13 - Decimo";
            fileName = fun.nomehl[15];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2019\01 - Janeiro";
            fileName = fun.nomehl[16];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            sourcePatch = @"C:\Users\Douglas\Desktop\AD\Contra Cheques\2019\02 - Fevereiro";
            fileName = fun.nomehl[17];
            sourceFile = System.IO.Path.Combine(sourcePatch, fileName);
            destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile)) {
                System.IO.File.Copy(sourceFile, destFile, true);
            }



            Console.ReadKey();
            
        }
    }
}
