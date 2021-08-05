﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDAL
    {
        #region costumer
        void addCostumer(Costumer costumer);
        void UpdateCostumer(Costumer costumer);
        BE.Costumer getCostumer(string id);
        List<BE.Costumer> getCostumers(Func<Costumer, bool> predicate = null);
        #endregion

        #region store
        void addStore(Store store);
        BE.Store getStore(int id);
        List<BE.Store> getStores(Func<Store, bool> predicate = null);
        #endregion

        #region product
        void addProduct(Product product);
        BE.Product getProduct(int id);
        List<BE.Product> getProducts(Func<Product, bool> predicate = null);
        #endregion

        #region QRcode
        void addQRcode(QRcode qRcode);
        BE.QRcode getQRcode(string code);
        List<BE.QRcode> getQRcodes(Func<QRcode, bool> predicate = null);
        #endregion

        #region purchase
        void addPurchase(Purchase purchases);
        bool deletePurchaseFromUserFile(int p);
        BE.Purchase getPurchase(int prid);
        List<BE.Purchase> getPurchaseForCostumer(string cid);
        List<BE.Purchase> getPurchases(Func<Purchase, bool> predicate = null);
        #endregion

        void createPDF(List<object[]> items);

    }
}