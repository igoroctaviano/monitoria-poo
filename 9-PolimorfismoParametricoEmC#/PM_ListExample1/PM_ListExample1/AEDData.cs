//
// Monitoria *Monitoring - Pontifícia Universidade Católica de Minas Gerais
// Unidade: São Gabriel
// Disciplina: Programação Orientada a Objetos
// *Discipline: Object-Oriented Programming
// Igor Octaviano
// https://github.com/igoroctaviano
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAD_Data_AED
{
    public class AEDData
    {
        private int dia, mes, ano;

        private AEDData() 
        {
        }

        public AEDData(int d, int m, int a){
            this.dia = d;
            this.mes = m;
            this.ano = a;
            if (!this.dataValida())
            {
                this.dia = 1;
                this.mes = 1;
                this.ano = 1977;
            }
        }

        private Boolean bissexto()
        {
            if ((this.ano%400)==0) return true;
            else if((this.ano%100)==0) return false;
                 else if ((this.ano%4)==0) return true;
                      else return false;
        }

        public Boolean dataValida()
        {
            Boolean resposta = true;
            switch (this.mes)
            {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (this.dia > 31){
                            resposta = false;
                        }
                        break;
                    case 2:
                        if (this.bissexto())
                        {
                            if (this.dia > 29)
                                resposta = false;
                        }
                        else
                            if (this.dia > 28)
                                resposta = false;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: 
                        if (this.dia > 30){
                            resposta = false;
                        }
                        break;
                   default:
                        resposta = false;
                        break;
                }
            return resposta;
        }

        public String getData(){
            
            return (String.Format("{0:d2}",this.dia)+ "/" + String.Format("{0:d2}",this.mes)+ "/" + this.ano);
        }

        public int diffDias(AEDData data2)
        {
            AEDData dataMenor, dataMaior;
            int menor=0;
            int cont = 0;

            menor = (this.ano-data2.ano);

            if(menor==0){
                menor = this.mes-data2.mes;
                if(menor==0){
                    menor = this.dia-data2.dia;
                    if(menor==0) return 0;
                }
            }

            if(menor<0){
                dataMenor = (AEDData)(this.MemberwiseClone());
                dataMaior = (AEDData)(data2.MemberwiseClone());
            }
            else{
                dataMenor = (AEDData)(data2.MemberwiseClone());
                dataMaior = (AEDData)(this.MemberwiseClone());
            }

            
            while ((dataMenor.dia != dataMaior.dia) || (dataMenor.mes != dataMaior.mes) || (dataMenor.ano != dataMaior.ano))
            {
                dataMenor.acrescentaDias(1);
                cont++;
            }
            return cont;

        }

        public void acrescentaDias(int quant){
            this.dia += quant;
            if (this.dia > 28){
                switch (this.mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (this.dia > 31)
                        {
                            this.dia = this.dia - 31;
                            this.mes++;
                        }
                        break;
                    case 2:
                        if (this.bissexto())
                        {
                            if (this.dia > 29)
                            {
                                this.dia = this.dia - 29;
                                this.mes++;
                            }
                        }
                        else
                        {
                            if (this.dia > 28)
                            {
                                this.dia = this.dia - 28;
                                this.mes++;
                            }
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: if (this.dia > 30)
                        {
                            this.dia = this.dia - 30;
                            this.mes++;
                        }
                        break;
                }
                if (this.mes > 12)
                {
                    this.mes = this.mes - 12;
                    this.ano++;
                }
            }
            

        }
    }
}
