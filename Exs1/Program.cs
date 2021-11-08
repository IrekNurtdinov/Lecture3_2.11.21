// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить
// большими "К", а большие "С" заменить маленькими "с".


string text = "И лампа не горит и врут календари"
            + "И если ты давно хотела что-то мне сказать, то говори"
            + "Любой обманчив звук, страшнее тишина"
            + "Когда в самый разгар веселья падает из рук бокал вина";

string TextChange(string text, char oldValue, char newValue)
{
   string result = String.Empty;
   
   int length = text.Length;
   for (int i = 0; i < length; i++)
   {

       if (text[i] == oldValue)
       {
           result = result + $"{newValue}";
       }
    else
    {
        result = result + $"{text[i]}";
    }

   }
   return result;

}
string newText = TextChange(text, ' ', '_');

//Console.WriteLine(TextChange(newText, 'к', 'К'));

string newText2 = TextChange(newText, 'И', '*');

Console.WriteLine(newText2);
