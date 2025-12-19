using System;
using System.Collections.Generic;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string modelo;
        private string imei;
        private int memoria;
        private int memoriaDisponivel;
        private readonly List<string> aplicativos = new();

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
            this.memoriaDisponivel = memoria;
        }

        public string GetModelo() => modelo;
        public string GetImei() => imei;
        public int GetMemoria() => memoria;
        public int GetMemoriaDisponivel() => memoriaDisponivel;
        public IReadOnlyList<string> AplicativosInstalados => aplicativos.AsReadOnly();

        // Método auxiliar que realiza a instalação real (checa duplicata e espaço)
        // Retorna true se a instalação ocorreu com sucesso.
        protected bool InstalarAplicativoBase(string nomeApp, int tamanhoEmMb = 10)
        {
            if (string.IsNullOrWhiteSpace(nomeApp))
                return false;

            if (aplicativos.Contains(nomeApp))
                return false; // já instalado

            if (tamanhoEmMb <= 0)
                tamanhoEmMb = 10;

            if (tamanhoEmMb > memoriaDisponivel)
                return false; // espaço insuficiente

            aplicativos.Add(nomeApp);
            memoriaDisponivel -= tamanhoEmMb;
            return true;
        }

        // Desinstala e libera espaço (tamanho padrão, pode ser sobrescrito)
        public virtual bool DesinstalarAplicativo(string nomeApp, int tamanhoEmMb = 10)
        {
            if (!aplicativos.Remove(nomeApp))
                return false;

            memoriaDisponivel += tamanhoEmMb;
            if (memoriaDisponivel > memoria)
                memoriaDisponivel = memoria;

            return true;
        }

        public IEnumerable<string> ListarAplicativos() => AplicativosInstalados;

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public override string ToString()
        {
            return $"{GetModelo()} - {Numero} (IMEI: {GetImei()})";
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}