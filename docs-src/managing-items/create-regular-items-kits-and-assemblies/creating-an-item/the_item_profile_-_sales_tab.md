---
title: The Item Profile - Sales
---

# The Item Profile - Sales


This tab is used to specify the price calculations, discount levels  and other sales information for the item.


Price Calculation


Use this tab to specify the price calculations, discount levels and  other sales information for the item. Right click and select **Insert**  to add additional measures. Right click and select **Delete**  to remove a measure from the list.


**Default**


Specify only one default sales measure from the drop-down list. Right  click the **Default** field and select  **Set As Default**.


**Measure**
: Specify the sales measure of the item. Only measures  with a conversion factor to the stock measure will be available in the  drop-down list. Measures listed here will be the only allowed sales measures  for this item in sales documents. Sales measures can be deleted (except  when defined as a measure for a free item or a get more item in the **Promotional Pricing** profile and the  promotion is valid during the current or future date) even if they are  used in documents and they can be added at any time. You can specify multiple  measures. When creating a sales or purchase document for an item, Everest  automatically retrieves the item into the document using the sales or  purchase measure defined for the item.


{:.note}
- This field defaults  to **Each** if the **Item 
 Type** selected in the **General**  tab of the **Item** profile is **Kit**. You can select any measure but  it will be considered with a quantity of one for a Kit.
- In case of a matrix  group, you are asked if you would like to apply the measure selected to  the matrix items as well.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [The  Measure Profile]({{site.mi_baseurl}}/item-profile-details/measure/measure_profile_general_tab.html)
: ![]({{site.mi_baseurl}}/img/lens.gif)[Sales  Measure]({{site.mi_baseurl}}/item-profile-details/other-items-information/sales/sales_measure_sales_info_item_profile.html)


**Type**
: This column will display the price type. Options  are **Fixed**, **% 
 Markup**, and **% Sales Total**.  **% Sales Total** is only available  for non-inventoried items.


**Price**
: Enter the price if you selected the **Fixed**  price type option. This field is disabled if you selected **% 
 Markup** or **% Sales Total**.


**Percentage**
: If you selected either the **% 
 Markup** or **% Sales Total**  price type option, this field is enabled. For **% 
 Markup**, enter the percentage markup that will be used to compute  the item price. For **% Sales Total**,  enter the percentage based on the sales total that will be used to compute  the item price.


**Minimum Amount**
: Enter the minimum price of the item. This field  is enabled when the **% Sales Total**  price type is selected. This field is only applicable to non-inventoried  items for each measure.


**Cost% of sell price**
: Enter the cost percentage of the item’s selling  price. This field is enabled only for a non-inventoried item and is applicable  to all three price types.
: This cost is a notional cost as it does not match  either the actual cost or the average cost.


{:.example}
: If you set up the cost of shipping to be 90% of  its selling price, and you bill $200 for shipping on a document, the cost  of shipping is computed at $180 but the bill that you receive from your  carrier for this may differ.
: When the cost of an item is calculated using this  method, on sale an accounting entry is made for the notional cost by debiting  the expense account for the item and crediting the liability account defined  for the item in the Accounts tab of the Item profile.


**Level Pricing**
: This field indicates if level pricing is being used  for this measure. Double-click the field to open the **Customer 
 Level Pricing** dialog box. Enter the customer level pricing schemes  in this dialog box.
: ![]({{site.mi_baseurl}}/img/lens.gif)[Customer  Level Pricing Dialog Box]({{site.mi_baseurl}}/item-profile-details/item-pricing/customer_level_pricing_dialog_box.html)
: ![]({{site.mi_baseurl}}/img/lens.gif)[Customer  Levels]({{site.mc_chm}}/customer-levels/customer_level.html)


**Quantity Pricing**
: This field indicates if quantity pricing is being  used for this measure. Double-click the field to open the **Quantity 
 Pricing** dialog box. Enter the quantity pricing schemes in this  dialog box.
: ![]({{site.mi_baseurl}}/img/lens.gif)[The  Quantity Pricing Dialog Box]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/quantity-pricing/quantity_pricing_item_fd.html)


**Freight**
: This field indicates if freight is being considered  for this measure. Double-click the field to open the **Item 
 Freight** dialog box. Enter the item freight details in this dialog  box.
: ![]({{site.mi_baseurl}}/img/lens.gif)[Item  Freight Dialog Box]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/item_freight_dialog_box_mi.html)


**Special Pricing**
: Click this button to specify the different pricing  schemes for the item in the **Special Pricing**  dialog box. This button is enabled when you save the profile. You can  set up the following pricing schemes for the item from this dialog box:

- : **Promotional 
 Pricing** – On the **Promotional Pricing**  tab, select **Options &gt; New &gt; In 
 New Window** to create a pricing scheme in the **Promotional 
 Pricing** dialog box.
- : **Special 
 Pricing** – On the **Special Pricing**  tab, select **Options &gt; New &gt; In 
 New Window** to create a pricing scheme in the **Special 
 Pricing** dialog box.
- : **Quantity 
 Discount** – On the **Quantity Discount**  tab, select **Options &gt; New &gt; In 
 New Window** to create a pricing scheme in the **Quantity 
 Discount** dialog box.

: ![]({{site.mi_baseurl}}/img/lens.gif)[The  Promotional Pricing Dialog Box]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/promotional-pricing/promotional_pricing_general_tab.html)
: ![]({{site.mi_baseurl}}/img/lens.gif)[Special  Pricing]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/special-pricing/special_pricing.html)
: ![]({{site.mi_baseurl}}/img/lens.gif)[The  Quantity Discount Dialog Box]({{site.mi_baseurl}}/item-profile-details/item-pricing/discounts-and-special-pricing/quantity-discounts/profile_quantity_discount_general_tab.html)


Other Sales Information


**Commission rate%**
: Enter the rate at which sales commission must be  paid to sales representatives for the sale of the item.


**Include in Commission Report Calculation**
: Select this check box if sales commission is payable  to sales representatives on sales of the item being defined, and the item  is included for commissions. The commission due to sales representatives  is calculated by the **Sales 
 Commission** and **Commission 
 (Quick Summary)** reports (path: **Reports 
 &gt; Invoicing**).
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Commissionable]({{site.mi_baseurl}}/item-profile-details/other-items-information/sales/commissionable.html)


**Tax inclusive selling price**
: Select this option to include the amount of tax  applicable to the item in the selling price of the item. When the item  is sold, the price is computed using the formula:
: Item Price = Selling price of the item + Tax applicable.


{:.example}
: If an item’s selling price is $110 which is inclusive  of 10% sales tax, the base selling price which accounts for the revenue  is $100.
: The purpose of arriving at this base selling price  is:

- : To identify  the revenues to be accounted.
- : To identify  the amount of tax payable to the Tax Authorities.
- : To compute  the discount, if any, on the base price rather than on the tax inclusive  price.
- : To compute  the commission payable to sales persons based on the revenues rather than  on the tax inclusive price.



{:.note}
**This option is not enabled for kit items.**


**Include in Freight Calculation**
: Use this option to indicate whether the weight of  this item is to be included when estimating freight on a sales document  in which the item is included.
: You can enter the weight for computation of freight  on sales in the **Weight** field of  the **Item Freight** dialog box. Double-click  the **Freight** field in the **Price Calculation** section grid. Freight  is computed on sales only for items that have this option selected.


{:.note}
- If  this option is not checked for a complete kit, but is checked for the  items contained in the kit, the complete kit is not considered for freight  calculation. Freight is not calculated and charged.
- When this option  is checked for a kit, freight is calculated based on the total weight  of the kit, after excluding all items, which have this option unchecked.  The item weights are recalculated based on the quantity of items.


{:.example}
If the freight calculation option is checked for a kit, and only  6  out of 8 items comprising the kit have the freight calculation option  checked, **Everest** considers only  the 6 items for calculating the document weight and applies the freight  rate for the document weight calculated.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Include  in freight calculation]({{site.mi_baseurl}}/item-profile-details/other-items-information/sales/include_in_freight.html)


**Pack Separately**
: Select this check box if the item has to be packed  separately while shipping. Freight is computed separately for each unit  of the item contained on sales and purchase documents.


{:.example}
A sales invoice contains three line items, A, B and C.  Item A is marked as “pack separately” while items B and C  do not have this option selected. 10 units of Item A and 2 units each  of items B and C  are shipped. The number of packages in this case are 11 (10+1). Freight  is computed for each unit of item A separately.


{:.note}
This field is disabled if the **Item 
 Type** selected in the **General**  tab of the **Item** profile is **Kit**. If this option is selected for  items that make up a kit, only those items will be packed separately.
: ![Lens.gif]({{site.mi_baseurl}}/img/lens.gif) [Miscellaneous  Sales Information]({{site.mi_baseurl}}/item-profile-details/other-items-information/sales/miscellaneous_sales_information_item_profile_contents.html)
: ![]({{site.mi_baseurl}}/img/lens.gif) [Freight  Calculations]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/how_everest_calculates_freight_rates_mi.html)


**Sales Price Decimal Accuracy**
: Specify the number of decimals between 0 and 6 to  be used for the sales price. The default sales price decimal accuracy  is the currency decimal accuracy. You can change the decimal accuracy  after the item is used in any document or pricing records are created.


{:.note}
**If you decrease the decimal accuracy, the  pricing records do not change. They have to be updated manually.**
: All prices on the **Sales**  tab are based on the **Sales Price Decimal 
 Accuracy**.


{:.note}
**All measures in the Item profile must have  the same Quantity Entry Method. This includes stock, sales, and purchase  measures. For serialized items, the stock measure is automatically selected  as the default sales measure and cannot be changed. You cannot select  additional sales measures for serialized items.**


The selling price of an item is the base price at which you sell the  item to your customer. The difference between the cost of the item (actual  cost in case of serialized inventory and average cost in case of non-serialized  inventory) and the selling price is your gross margin of profit. Use Item  pricing in Everest to:

1. : Select from  three different methods of price calculations.
- : Specify different  prices for different customer levels.
- : Specify different  prices for different quantity levels.
- : Set up discount  schemes for the item based on quantity or customer.
- : Define promotional  schemes.



{:.note}
- Selling prices  set up in the **Item** profile can  be changed in individual sales documents.


{:.see_also}
See also
: [Items]({{site.mi_baseurl}}/items_introduction.html)
