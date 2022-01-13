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
    }
}