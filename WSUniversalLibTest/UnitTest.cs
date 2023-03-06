using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace WSUniversalLibTest
{
    [TestClass]
    public class UnitTest
    {
        private int NON_EXISTED_TYPE = -1;
        private int ERROR_RESPONSE = -1;

        private int PRODUCT_TYPE_CORRECT = 3;
        private int MATERIAL_TYPE_CORRECT = 1;

        private int COUNT_CORRECT = 15;

        private int WIGHT_CORRECT = 20;
        private int HEIGHT_CORRECT = 45;

        private int CALCULATION_CORRECT = 114147;



        private int NULL = 0;
        [TestMethod]
        public void GetQuantityForProduct_CorrectData()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(PRODUCT_TYPE_CORRECT, MATERIAL_TYPE_CORRECT, COUNT_CORRECT, WIGHT_CORRECT, HEIGHT_CORRECT);
            //Assert
            Assert.AreEqual(CALCULATION_CORRECT, calc);
        }
        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(NON_EXISTED_TYPE, MATERIAL_TYPE_CORRECT, COUNT_CORRECT, WIGHT_CORRECT, HEIGHT_CORRECT);
            //Assert
            Assert.AreEqual(ERROR_RESPONSE, calc);
        }
        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType()
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(PRODUCT_TYPE_CORRECT, NON_EXISTED_TYPE, COUNT_CORRECT, WIGHT_CORRECT, HEIGHT_CORRECT);
            //Assert
            Assert.AreEqual(ERROR_RESPONSE, calc);
        }
        [TestMethod]
        public void GetQuantityForProduct_WrongCount()
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(PRODUCT_TYPE_CORRECT, MATERIAL_TYPE_CORRECT, NON_EXISTED_TYPE, WIGHT_CORRECT, HEIGHT_CORRECT);
            //Assert
            Assert.AreEqual(ERROR_RESPONSE, calc);
        }
        [TestMethod]
        public void GetQuantityForProduct_NonExistentWidth()
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(PRODUCT_TYPE_CORRECT, MATERIAL_TYPE_CORRECT, COUNT_CORRECT, NON_EXISTED_TYPE, HEIGHT_CORRECT);
            //Assert
            Assert.AreEqual(ERROR_RESPONSE, calc);
        }
        [TestMethod]
        public void GetQuantityForProduct_NonExistentLenght()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(PRODUCT_TYPE_CORRECT, MATERIAL_TYPE_CORRECT, COUNT_CORRECT, WIGHT_CORRECT, NON_EXISTED_TYPE);
            //Assert
            Assert.AreEqual(ERROR_RESPONSE, calc);
        }
        [TestMethod]
        public void GetQuantityForProduct_NullProductType()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(NULL, MATERIAL_TYPE_CORRECT, COUNT_CORRECT, WIGHT_CORRECT, HEIGHT_CORRECT);
            //Assert
            Assert.AreEqual(ERROR_RESPONSE, calc);
        }
        [TestMethod]
        public void GetQuantityForProduct_NullMaterialType()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(PRODUCT_TYPE_CORRECT, NULL, COUNT_CORRECT, WIGHT_CORRECT, HEIGHT_CORRECT);
            //Assert
            Assert.AreEqual(ERROR_RESPONSE, calc);
        }
        [TestMethod]
        public void GetQuantityForProduct_NullCount()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(PRODUCT_TYPE_CORRECT, MATERIAL_TYPE_CORRECT, NULL, WIGHT_CORRECT, HEIGHT_CORRECT);
            //Assert
            Assert.AreEqual(NULL, calc);
        }
        [TestMethod]
        public void GetQuantityForProduct_NegativeSquare()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(PRODUCT_TYPE_CORRECT, MATERIAL_TYPE_CORRECT, COUNT_CORRECT, WIGHT_CORRECT, NON_EXISTED_TYPE);
            //Assert
            Assert.AreEqual(ERROR_RESPONSE, calc);
        }
    }
}
