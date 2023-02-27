using System;
using System.IO;

class BinaryExperiment
{
    const string SettingsFileName = @"c:\BinaryFile.bin";

    static void Main()
    {
        WriteValues();
        // Считываем
        ReadValues();
    }

    static void WriteValues()
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName, FileMode.Open)))
            writer.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
    }
    static void ReadValues()
    {
       
        string StringValue;
      

        if (File.Exists(SettingsFileName))
        {
            // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
            using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
            {
                // Применяем специализированные методы Read для считывания соответствующего типа данных.
               
                StringValue = reader.ReadString();
                
            }

            Console.WriteLine("Из файла считано:");

           
            Console.WriteLine(StringValue);
           
        }
    }
}
