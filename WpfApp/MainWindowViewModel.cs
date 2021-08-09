using System.ComponentModel;

namespace WpfApp
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _text1;
        private string _text2;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Text1
        {
            get => _text1;
            set
            {
                _text1 = value;
                OnPropertyChanged(nameof(Text1));
            }
        }

        public string Text2
        {
            get => _text2;
            set
            {
                _text2 = value;
                OnPropertyChanged(nameof(Text2));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}