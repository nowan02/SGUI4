using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.ViewModel;
using System.ComponentModel;

namespace ToDoList.Command
{
    internal class AddCommand : BaseCommand
    {
        protected BasicVM viewModel { get; }
        public AddCommand(BasicVM viewModel)
        {
            this.viewModel = viewModel;
            this.viewModel.PropertyChanged += ViewModelPropertyChanged;
        }
        public override void Execute(object? parameter)
        {
            BasicVM.ObservableColl.Add(new BasicVM());
            viewModel.OnPropertyChanged(nameof(BasicVM.ObservableColl));
        }

        protected void ViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(BasicVM.ObservableColl)) OnCanExecuteChanged();
        }

        public override bool CanExecute(object? parameter)
        {
            return base.CanExecute(parameter);
        }
    }
}
