public static class GerarPalavra
{
    public static string ListaAleatorio()
    {
        string[] Lista = [
                    "CARRO",
                    "MANGA",
                    "VERDE",
                    "PRETO",
                    "BRAVO",
                    "FELIZ",
                    "FORTE",
                    "LENTO",
                    "GARFO",
                    "CLARO",
                    "SANTO",
                    "MAGRO",
                    "GORDO",
                    "CALMO",
                    "TENSA",
                    "PRATO",
                    "FALAR",
                    "DOCES",
                    "MENTE",
                    "AMIGO",
                    "RADIO",
                    "SONHO",
                    "MEDOS",
                    "RISCO",
                    "VALOR",
                    "TEMPO",
                    "HORAS",
                    "MANHA",
                    "NOITE",
                    "TARDE"
                ];
        Random random = new Random(); //não importei a system.cryptograph pois eu não achei necessário o uso dela para esse projeto, já que ele é mais simples de usar
        int dicionario = random.Next(Lista.Length);
        return Lista[dicionario];
    }
}