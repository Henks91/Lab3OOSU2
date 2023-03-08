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
            get => tillgängligaBöckerSelectedItem;
            set
            {
                tillgängligaBöckerSelectedItem = value; OnPropertyChanged();
            }
        
                //if (medlemSelectedItem != null)
                //{
                //    IList<Bok> allaBöcker = kontroller.HämtaTillgängligaBöcker();

                //    TillgängligaBöcker = new ObservableCollection<Bok>(allaBöcker.Where(i => !ValdaBöcker.Select(di => di.ISBN).Contains(i.ISBN)).ToList());
                //    TillgängligaBöckerSelectedIndex = (TillgängligaBöcker.Count > 0) ? 0 : -1;

                //    Status = $"Tillgängliga Böcker #{TillgängligaBöckerSelectedItem?.ISBN}: {TillgängligaBöckerSelectedItem?.Titel}";
                //}
                    //IList<Bok> boks = kontroller.HämtaTillgängligaBöcker();
                    //TillgängligaBöcker = (ObservableCollection<Bok>)boks;


                //    IList<Bok> allaBöcker = kontroller.HämtaTillgängligaBöcker();

                //TillgängligaBöcker = new ObservableCollection<Bok>(allaBöcker.Where(i => !ValdaBöcker.Select(di => di.ISBN).Contains(i.ISBN)).ToList());
                //TillgängligaBöckerSelectedIndex = (TillgängligaBöcker.Count > 0) ? 0 : -1;
                
                //Status = $"Tillgängliga Böcker #{TillgängligaBöckerSelectedItem?.ISBN}: {TillgängligaBöckerSelectedItem?.Titel}";
                //if (medlemSelectedItem != null)
                //{
                //    IList<Bok> boks = kontroller.HämtaTillgängligaBöcker();
                //    TillgängligaBöcker = (ObservableCollection<Bok>)boks;
                //}
            
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
                if (medlemSelectedItem != null)
                {
                    ValdaBöcker = new ObservableCollection<Bok>();

                    IList<Bok> allaBöcker = kontroller.HämtaTillgängligaBöcker();

                    TillgängligaBöcker = new ObservableCollection<Bok>(allaBöcker.Where(i => !ValdaBöcker.Select(di => di.ISBN).Contains(i.ISBN)).ToList());
                    //new ObservableCollection<Bok>(allaBöcker.Where(i => !ValdaBöcker.Select(di => di.ISBN).Contains(i.ISBN)).ToList());
                    TillgängligaBöckerSelectedIndex = (TillgängligaBöcker.Count > 0) ? 0 : -1;

                    Status = $"Tillgängliga Böcker #{TillgängligaBöckerSelectedItem?.ISBN}: {TillgängligaBöckerSelectedItem?.Titel}";
                }
                Status = $"Vald medlem: {MedlemSelectedItem?.MedlemsId}: " +
                    $"{MedlemSelectedItem?.Namn}";
            }
        }
            

        public MainViewModel()
        {
            kontroller = new Kontroller();

            Boks = new ObservableCollection<Bok>();
            Bokning = new ObservableCollection<Bokning>();
            Faktura = new ObservableCollection<Faktura>();
            TillgängligaBöcker = new ObservableCollection<Bok>();

            RefreshCommand.Execute(null);
        }

        //private ICommand removeCommand = null!;
        //public ICommand RemoveCommand => removeCommand ??= removeCommand = new RelayCommand(() =>
        //{
        //    if (dishesSelectedItem != null && ingredientsSelectedItem != null)
        //    {
        //        Ingredient ingredient = ingredientsSelectedItem;
        //        DishIngredient di = dishesSelectedItem.DishIngredients.FirstOrDefault(di => di.DishId == dishesSelectedItem.Id && di.IngredientId == ingredient.Id);
        //        dishesSelectedItem.DishIngredients.Remove(di);
        //        AvailableIngredients.Add(ingredient);
        //        Ingredients.Remove(ingredient);

        //        Status = $"Removed ingredient #{ingredient.Id} ({ingredient.Name}) from dish #{dishesSelectedItem.Id} ({dishesSelectedItem.Name})";

        //        IsNotModified = false;
        //    }
        //}, () => Ingredients.Count > 0);

        //private ICommand addCommand = null!;
        //public ICommand AddCommand => addCommand ??= addCommand = new RelayCommand(() =>
        //{
        //    if (dishesSelectedItem != null && availableIngredientsSelectedItem != null)
        //    {
        //        Ingredient ingredient = availableIngredientsSelectedItem;
        //        dishesSelectedItem.DishIngredients.Add(new DishIngredient { DishId = dishesSelectedItem.Id, Dish = dishesSelectedItem, IngredientId = ingredient.Id, Ingredient = ingredient });
        //        Ingredients.Add(ingredient);
        //        AvailableIngredients.Remove(ingredient);

        //        Status = $"Added ingredient #{ingredient.Id} ({ingredient.Name}) to dish #{dishesSelectedItem.Id} ({dishesSelectedItem.Name})";

        //        IsNotModified = false;
        //    }
        //}, () => AvailableIngredients.Count > 0);

        //private ICommand saveCommand = null!;
        //public ICommand SaveCommand => saveCommand ??= saveCommand = new RelayCommand(() =>
        //{
        //    if (dishesSelectedItem != null)
        //    {
        //        pizzeriaController.UpdateDish(dishesSelectedItem);
        //        Status = $"Saved changes for dish #{dishesSelectedItem.Id} ({dishesSelectedItem.Name})";
        //        IsNotModified = true;
        //    }
        //}, () => !IsNotModified);

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
