using Business.Classes;
using BusinessLayer;
using PresentationsLager.WPF.MVVM.Commands;
using PresentationsLager.WPF.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PresentationsLager.WPF.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private Kontroller kontroller;

        private ObservableCollection<Bok> valdaBöcker = null!;
        public ObservableCollection<Bok> ValdaBöcker { get => valdaBöcker; set { valdaBöcker = value; OnPropertyChanged(); } }
        private ObservableCollection<Bok> tillgängligaBöcker = null!;
        public ObservableCollection<Bok> TillgängligaBöcker { get => tillgängligaBöcker; set { tillgängligaBöcker = value; OnPropertyChanged(); } }
        private ObservableCollection<Bok> bokningensBöcker = null!;
        public ObservableCollection<Bok> BokningensBöcker { get => bokningensBöcker; set { tillgängligaBöcker = value; OnPropertyChanged(); } }
        private Bokning valdBokning;
        public Bokning ValdBokning { get => valdBokning; set { valdBokning = value; OnPropertyChanged(); } }


        private string status = "Ready";
        public string Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged(); }
        }

        private bool isNotModified = true;
        public bool IsNotModified
        {
            get { return isNotModified; }
            set { isNotModified = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Bok> boks = null!;
        public ObservableCollection<Bok> Boks
        {
            get => boks;
            set { boks = value; OnPropertyChanged(); }
        }

        private DateTime startLån;  //FIXA SENARE
        public DateTime StartLån
        {
            get
            {
                return startLån;
            }
            set
            {
                startLån = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Bokning> bokning = null!;
        public ObservableCollection<Bokning> Bokning
        {
            get => bokning;
            set { bokning = value; OnPropertyChanged(); }
        }
        private ObservableCollection<Faktura> faktura = null!;
        public ObservableCollection<Faktura> Faktura
        {
            get => faktura;
            set { faktura = value; OnPropertyChanged(); }
        }
        private int tillgängligaBöckerSelectedIndex;
        public int TillgängligaBöckerSelectedIndex { get { return tillgängligaBöckerSelectedIndex; } set { tillgängligaBöckerSelectedIndex = value; OnPropertyChanged(); } }

        private Bok tillgängligaBöckerSelectedItem = null!;
        public Bok TillgängligaBöckerSelectedItem
        {
            get { return tillgängligaBöckerSelectedItem; }
            set
            {
                tillgängligaBöckerSelectedItem = value; OnPropertyChanged();              
                Status = $"Selected available ingredient #{TillgängligaBöckerSelectedItem?.ISBN}: {TillgängligaBöckerSelectedItem?.Titel}";
            }           
        }

        private int valdaBöckerSelectedIndex;
        public int ValdaBöckerSelectedIndex { get { return valdaBöckerSelectedIndex; } set { valdaBöckerSelectedIndex = value; OnPropertyChanged(); } }

        private Bok valdaBöckerSelectedItem = null!;
        public Bok ValdaBöckerSelectedItem
        {
            get { return valdaBöckerSelectedItem; }
            set
            {
                valdaBöckerSelectedItem= value;
                OnPropertyChanged();
                Status = $"Valda böcker #{ValdaBöckerSelectedItem?.ISBN}: {ValdaBöckerSelectedItem?.Titel}";
            }
        }

        private int bokningNr;
        public int BokningNr
        {
            get { return bokningNr; }
            set 
            {               
                bokningNr = value; OnPropertyChanged();
                ValdBokning = kontroller.HämtaBokning(bokningNr);
                BokningensBöcker = new ObservableCollection<Bok>(kontroller.HämtaBokningensBöcker(bokningNr));
                Status = $"Visar bokningen med bokningsnummer: {valdBokning.BokningId}";
            }
        }


        private ObservableCollection<Medlem> medlem = null!;
        public ObservableCollection<Medlem> Medlem
        {
            get => medlem;
            set { medlem = value; OnPropertyChanged(); }
        }

        private int medlemSelectedIndex;
        public int MedlemSelectedIndex
        {
            get { return medlemSelectedIndex; }
            set 
            { 
                medlemSelectedIndex = value; OnPropertyChanged();              
            }
        }
        private Medlem medlemSelectedItem = null!;
        public Medlem MedlemSelectedItem
        {
            get { return medlemSelectedItem; }
            set
            {
                medlemSelectedItem = value; OnPropertyChanged();
<<<<<<< HEAD
                if (medlemSelectedItem != null)
                {
                    ValdaBöcker = new ObservableCollection<Bok>();
=======
>>>>>>> origin/Calle

                TillgängligaBöcker = new ObservableCollection<Bok>(kontroller.HämtaAllaBöcker());
                ValdaBöcker = new ObservableCollection<Bok>();
                Status = $"Tillgängliga Böcker #{TillgängligaBöckerSelectedItem?.ISBN}: {TillgängligaBöckerSelectedItem?.Titel}";
                
                Status = $"Vald medlem: {MedlemSelectedItem?.MedlemsId}: " +
                    $"{MedlemSelectedItem?.Namn}";
            }
        }
        


        public MainViewModel()
        {
            kontroller = new Kontroller();
            kontroller.LaddaData();

            Boks = new ObservableCollection<Bok>();
            Bokning = new ObservableCollection<Bokning>();
            Faktura = new ObservableCollection<Faktura>();
            TillgängligaBöcker = new ObservableCollection<Bok>();
            

            RefreshCommand.Execute(null);
        }

        private ICommand removeCommand = null!;
        public ICommand RemoveCommand => removeCommand ??= removeCommand = new RelayCommand(() =>
        {
            if (valdaBöckerSelectedItem != null)
            {
                Bok bok = valdaBöckerSelectedItem;
                //DishIngredient di = dishesSelectedItem.DishIngredients.FirstOrDefault(di => di.DishId == dishesSelectedItem.Id && di.IngredientId == ingredient.Id);
                //dishesSelectedItem.DishIngredients.Remove(di);
                TillgängligaBöcker.Add(bok);
                ValdaBöcker.Remove(bok);

                Status = $"Removed bok #{bok.Titel} ({bok.ISBN})";

                IsNotModified = false;
            }
        }); //, () => ValdaBöcker.Count > 0

        private ICommand addCommand = null!;
        public ICommand AddCommand => addCommand ??= addCommand = new RelayCommand(() =>
        {
            if (tillgängligaBöckerSelectedItem != null)
            {
                Bok bok = tillgängligaBöckerSelectedItem;


                ValdaBöcker.Add(bok);
                TillgängligaBöcker.Remove(bok);

                Status = $"Added bok #{bok.Titel} ({bok.ISBN})";

                IsNotModified = false;
            }
        }); //, () => TillgängligaBöcker.Count > 0

        private ICommand saveCommand = null!;
        public ICommand SaveCommand => saveCommand ??= saveCommand = new RelayCommand(() =>
        {
            if (valdaBöcker != null)
            {
                Expidit exp = kontroller.HämtaExpidit(1);
                Bokning bokning = kontroller.SkapaBokning(MedlemSelectedItem, exp, StartLån, ValdaBöcker);
                Status = $"Skapat bokning med följande bokningsId: {bokning.BokningId})";
                IsNotModified = true;
            }
        }, () => !IsNotModified);

        private ICommand exitCommand = null!;
        public ICommand ExitCommand =>
        exitCommand ??= exitCommand = new RelayCommand(() => App.Current.Shutdown());

        private ICommand refreshCommand = null!;
        public ICommand RefreshCommand => refreshCommand ??= refreshCommand = new RelayCommand(() =>
        {

            Medlem = new ObservableCollection<Medlem>(kontroller.Hittamedlem());
            MedlemSelectedItem = (Medlem.Count > 0) ? Medlem[0] : null!;
            IsNotModified = true;
        });

    }
}
