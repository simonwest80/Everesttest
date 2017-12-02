---
title: Default Stock Area
---

# Default Stock Area


**Everest**<font color="#000000" class="hcp2"> allows inventory to be automatically transferred to 
 a stock area when a document is processed.</font>


{:.example}
Inventory can be automatically moved into  the Main Stock Area when a Purchase Receipt or Invoice is created, or  inventory can be moved into the Released area when a Sales Invoice is  created.


Stock areas are affected  in the following cases:

- <font color="#000000" class="hcp2">Inventory is received on a purchase receipt or invoice, 
 or returned on a debit memo.</font>
- <font color="#000000" class="hcp2">Inventory is issued on a sales invoice or received on 
 a credit memo.</font>
- <font color="#000000" class="hcp2">Inventory is assigned or unassigned on an order.</font>



You can specify default stock areas for each of these functions in the  **Stock** **Transfer**  tab of the **Location** profile (path:  **File** > **Setup**  > **Accounting** > **Location**/**Sub-Location** > From the **Location/Sub-Locations** browser, double-click on the required record).


{:.note}
The stock area can be changed on each document  at the time of receipt or sale.


**<font color="#000000" class="hcp2">The Location Profile - Stock 
 Transfer Tab - Purchase Document</font>**


<font color="#000000" class="hcp2">This profile is used to specify the stock areas to 
 which items should be transferred when a purchase document such as purchase 
 order, purchase receipt, purchase invoice, debit order and debit memo 
 are created and items are received/returned on them.</font>


![]({{site.sc_baseurl}}/img/lens.gif)<font color="#000000" class="hcp2"> </font>[The  **Location** Profile - Stock Transfer  - Purchase Documents]({{site.sc_baseurl}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_stock_transfer.html)


**<font color="#000000" class="hcp2">The Location Profile - Stock 
 Transfer Tab - Sales Documents</font>**


<font color="#000000" class="hcp2">This profile is used to specify the stock areas to 
 which items should be transferred when a sales document such as sales 
 order, sales invoice, credit order and credit memo are created and items 
 are dispatched/returned on them.</font>


{:.example}
If you have indicated CSHIP  (customer shipment expected) as the default stock area when items are  attached to a sales order, **Everest**  will automatically transfer items to CSHIP  whenever a sales order is created and items are assigned to it.


![]({{site.sc_baseurl}}/img/lens.gif)<font color="#000000" class="hcp2"> </font>[The  **Location** Profile - Stock Transfer  - Sales Documents]({{site.sc_baseurl}}/options/locations-and-sub-locations/set-up-locations/the_location_profile_stock_transfer.html)


{:.see_also}
See also
: [Creating  a Stock Area]({{site.sc_baseurl}}/options/miscellaneous-set-up/stock-areas/stock-areas/creating_a_new_stock_area.html)<font color="#000000" class="hcp2"> </font>
: [Stock  Areas and Measures]({{site.sc_baseurl}}/the-company-creation-wizard/inventory/inventory_stock_areas_measures_defaults.html)<font color="#000000" class="hcp2"> </font>
