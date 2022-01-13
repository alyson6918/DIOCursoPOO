namespace DIOExemploPOO.helper
{
    public class FileHelper
    {
        public void lsTopDirectory(string _path){
            var returnPath = Directory.GetDirectories(_path, "*", SearchOption.TopDirectoryOnly);
            foreach(var returns in returnPath){
                System.Console.WriteLine(returns);
            }
        }
        public void lsAllDirectory(string _path){
            var returnPath = Directory.GetDirectories(_path, "*", SearchOption.AllDirectories);
            foreach(var returns in returnPath){
                System.Console.WriteLine(returns);
            }
        }
        public void lsTopArchiveDirectory(string _path){
            var returnPath = Directory.GetFiles(_path, "*", SearchOption.TopDirectoryOnly);
            foreach(var returns in returnPath){
                System.Console.WriteLine(returns);
            }
        }
        public void lsAllArchiveDirectory(string _path){
            var returnPath = Directory.GetFiles(_path, "*", SearchOption.AllDirectories);
            foreach(var returns in returnPath){
                System.Console.WriteLine(returns);
            }
        }
        public void CreateDirectory(string _path){
            var returns = Directory.CreateDirectory(_path);
            System.Console.WriteLine(returns.FullName);
        }
        public void DeleteDirectory(string _path, bool archivesIncluded){Directory.Delete(_path, archivesIncluded);}
        public void CreateTextArchive(string _path, string content, bool overrideArchive){
            if (File.Exists(_path) && overrideArchive == false){
                System.Console.WriteLine("O arquivo ja existe e você optou por não o sobrescrever-lo");
            }else{
                File.WriteAllText(_path, content);
                System.Console.WriteLine("Arquivo criado com sucesso!!");
            }
        }
        public void CreateStreamTextArchive(string _path, List<string> content, bool overrideArchive){
            if(File.Exists(_path) && overrideArchive == false){System.Console.WriteLine("O arquivo ja existe e você escolheu não sobrescrever-lo");}
            else{
                using (var stream = File.CreateText(_path)){
                    System.Console.WriteLine("Arquivo criado com sucesso!!");
                    foreach(var line in content){stream.WriteLine(line);}
                    System.Console.WriteLine("Arquivo escrito com sucesso!!");
                }    
            }
        }
        public void AddText(string _path, string content, bool create){
            if (!File.Exists(_path) && create == false){
                System.Console.WriteLine("O arquivo em questão não existe e você optou por não criar um novo");
            }else if (File.Exists(_path)){
                File.AppendAllText(_path, content);
                System.Console.WriteLine("arquivo escrito com sucesso!!");
            }else{
                File.AppendAllText(_path, content);
                System.Console.WriteLine("o arquivo foi criado e escrito com sucesso!!");
            }
        }
        public void AddStreamText(string _path, List<string> content, bool create){
            if(!File.Exists(_path) && create == false){System.Console.WriteLine("O arquivo em questão não existe e você optou por não criar um novo");}
            else if(File.Exists(_path)){
                using (var stream = File.AppendText(_path)){
                    System.Console.WriteLine("Arquivo encontrado com sucesso!!");
                    foreach(var line in content){stream.WriteLine(line);}
                    System.Console.WriteLine("Texto adicionado com sucesso!!");
                }    
            }
            else{
                using (var stream = File.AppendText(_path)){
                    System.Console.WriteLine("Arquivo criado com sucesso!!");
                    foreach(var line in content){stream.WriteLine(line);}
                    System.Console.WriteLine("Texto adicionado com sucesso!!");
                }
            }
        }
    }
}