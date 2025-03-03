﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.Shop.IServices;
using Vavatech.Shop.Models;

namespace Vavatech.Shop.ViewModels
{
    public class EntitiesViewModel<TEntity> : BaseViewModel
        where TEntity : BaseEntity
    {
        private readonly IEntityService<TEntity> entityService;

        public IEnumerable<TEntity> Entities { get; set; }

        private TEntity selected;
        public TEntity Selected
        {
            get => selected;
            set
            {
                selected = value;
                OnPropertyChanged();

                // messageAggregator.Publish<CustomerSelectedMessage>(new CustomerSelectedMessage((Selected));


            }
        }

        public EntitiesViewModel(IEntityService<TEntity> entityService)
        {
            this.entityService = entityService;
            Load();
        }

        private void Load()
        {
            Entities = entityService.Get();
        }
    }

    public class CustomersViewModel : EntitiesViewModel<Customer>
    {
        public IEnumerable<Customer> Customers => Entities;

        public CustomersViewModel(ICustomerService entityService) : base(entityService)
        {
        }
    }
}
