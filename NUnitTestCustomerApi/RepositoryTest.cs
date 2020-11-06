using MFPE_CustomerApi.Models;
using MFPE_CustomerApi.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestCustomerApi
{
    class RepositoryTest
    {
        private CustomerRepository TokenObj;


        [SetUp]
        public void Setup()
        {

            TokenObj = new CustomerRepository();

        }
        [Test]
        public void getCustomerAccounts_Called_When_Given_Invalid_CustomerId()
        {

            var result = TokenObj.Get(0);

            Assert.That(result, Is.Null);
        }
        [Test]
        public void getCutomerAccounts_Called_When_Given_Valid_CustomerId()
        {


            var result = TokenObj.Get(1);

            Assert.That(result, Is.Not.Null);
        }
        [Test]
        public void getAllDetails_IsCalled()
        {
          new List<Customer> { new Customer() {
          CustomerId = 1,
                    Name = "Mansi",
                    Address = "Dehradun",
                    DOB = Convert.ToDateTime("1998-11-20 01:02:01 AM"),
                    PANno = "DCRP4536",} };
                

            var result = TokenObj.GetAll();


            Assert.That(result, Is.Not.Null);
        }
        [Test]
        public void Post_When_Add_IsCalled()
        {
            Customer customer = new Customer();
            var result = TokenObj.Add(customer);
            Assert.That(result, Is.Not.Null);
        }
       
    }
}
