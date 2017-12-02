---
title: Set up for Finance Charges
---

# Set up for Finance Charges


Finance charges are set up in the **Customer** profile. The **Customer** profile (path: **Invoicing** > **Customers** > **Options** > **Edit** > **In New Window** > **Finance Charges** tab) contains the following finance charges related options:


**Compute Method**
: This field denotes the method that is to be used for calculating finance charges for this customer. Finance charges can be computed as a percentage or fixed amount. If you do not want to specify finance charges for a customer, then set this field to **None**.


![]({{site.sp_baseurl}}/img/lens.gif)[Finance Charges]({{site.mc_chm}}/customer-details/finance-charges/finance_charges_content.html)


**Rate**
: This field denotes the rate at which finance charges have to be calculated for the customer. If the computation method selected is **Percentage**, then enter the rate at which the finance charges has to be calculated.
: If the computation method selected is **Fixed**, then enter the fixed amount of finance charge that has to be applied to the customer.
: This field is disabled if **None** is selected as the computation method.


**Days past due**
: This field denotes the number of days from the document date after which finance charges have to be charged to a customer.


**Exclude unpaid finance charges**
: If you want to charge the finance charge only on the outstanding amount, then select this option. If you want to charge finance charges on previous unpaid finance charges also, then do not select this check box.


![]({{site.sp_baseurl}}/img/example.gif)  The outstanding amount from a customer is $ 1,000 and the finance charge is 10%.   When finance charges are applied on the invoice amount for the first time, the finance charge will be $ 100. The total outstanding amount from the customer becomes $ 1,100.


**Let us assume that the customer has not paid the amount and you have to calculate finance charges for the next month.**


****Case 1**: If you have selected the **Exclude unpaid finance charges** option, then the 10% finance charge for the second month will be calculated only on $ 1,000.**


****Case 2**: If you have NOT selected the **Exclude unpaid finance charges** option, then the 10% finance charge for the second month will be calculated on $ 1,100.**


**Minimum balance**
: This field denotes the minimum outstanding balance on which finance charges can be applied. If the outstanding balance from the customer is below the amount mentioned here, finance charges will not be computed for the customer.


{:.see_also}
See also
: [Finance Charges]({{site.sp_baseurl}}/sales-docs/finance-charges/finance_charges.html)
: [Processing Finance Charges]({{site.sp_baseurl}}/sales-docs/finance-charges/processing-finance-charges/processing_finance_charges.html)
