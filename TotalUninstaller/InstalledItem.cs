using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TotalUninstaller
{
    public class InstalledItem : INotifyPropertyChanged
    {
        public string   Product         { get; set; }
        public string   ProductCode     { get; set; }
        public DateTime   InstallDate     { get; set; }
        public string   InstallLocation { get; set; }
        public Uri      Url             { get; set; }
        public Version  Version         { get; set; }
        public string Publisher { get; set; }
        public string Tooltip { get; set; }

        private bool _uninstall;

        public bool Uninstall
        {
            get
            {
                return _uninstall;
            }
            set
            {
                _uninstall = value;
                OnPropertyChanged();
            }
        }

        public InstalledItem(string product, string productCode, DateTime installDate, string installLocation, Uri url, Version version, string publisher)
        {
            Product         = product;
            ProductCode     = productCode;
            InstallDate     = installDate;
            InstallLocation = installLocation;
            Url             = url;
            Version         = version;
            Publisher       = publisher;

            Tooltip = Product + ProductCode;
        }

        public override string ToString()
        {
            return Product;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null) { PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName)); }
        }
    }
}
