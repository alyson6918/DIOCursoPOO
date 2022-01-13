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
        public void ReadTextArchive(string _path){
            if(File.Exists(_path)){
                var content = File.ReadAllLines(_path);
                foreach(var line in content){System.Console.WriteLine(line);}
            }
            else{System.Console.WriteLine("O arquivo em especifico não foi encontrado ou não existe");}
        }
        public void ReadStreamArchive(string _path){
            if(File.Exists(_path)){
                string? line = string.Empty;
                using (var stream = File.OpenText(_path)){
                    while((line = stream.ReadLine()) != null){
                        System.Console.WriteLine(line);
                    }
                }
            }
            else{System.Console.WriteLine("O arquivo em especifico não foi encontrado ou não existe");}
        }
        public void MoveArchive(string _path, string destiny, bool overrideArchive){
            if(!File.Exists(_path)){System.Console.WriteLine("O arquivo em questão não foi encontrado ou não existe");}
            else if(File.Exists(_path) && File.Exists(destiny) && overrideArchive == false){System.Console.WriteLine("Já existe um arquivo com o mesmo nome no caminho de destino e você optou por não sobrescrever-lo");}
            else if(File.Exists(_path) && File.Exists(destiny) && overrideArchive == true){
                File.Move(_path, destiny, overrideArchive);
                System.Console.WriteLine("O arquivo sobrescrito com sucesso");
            }
            else{
                File.Move(_path, destiny, overrideArchive);
                System.Console.WriteLine("O arquivo movido com sucesso");
            }
        }
        public void CopyArchive(string _path, string destiny, bool overrideArchive){
            if(File.Exists(_path) && !File.Exists(destiny)){
                File.Copy(_path, destiny, overrideArchive);
                System.Console.WriteLine("O arquivo foi copiado com sucesso");
            }
            else if(File.Exists(_path) && File.Exists(destiny) && overrideArchive == false){System.Console.WriteLine("O arquivo já existe na pasta de destino e você optou por não o sobrescrever-lo");}
            else if(File.Exists(_path) && File.Exists(destiny) && overrideArchive == true){
                File.Copy(_path, destiny, overrideArchive);
                System.Console.WriteLine("O arquivo foi copiado e sobrescrito com sucesso");
            }
            else{System.Console.WriteLine("O arquivo em questão não foi encontrado ou não existe");}
        }
        public void DeleteArchive(string _path){
            if (File.Exists(_path)){
                File.Delete(_path);
                System.Console.WriteLine("O arquivo foi deletado com sucesso");
            }
            else{System.Console.WriteLine("O arquivo não foi encontrado ou não existe");}
        }
    }
}