---
title: Freight Calculations
---

# Freight Calculations


Freight rates are defined for each delivery method (Ship-via agent),  such as UPS Ground and FedEx. For each Ship-via agent, you can define  rates based on the following rate types in the **Rates**  profile (path: **File** > **Setup** > **Freight 
 &gt; Rates**): ****

- **Category/Item 
 (Product)** - This is a “product” type method which allows you to  calculate freight based on each product. Rates can be assigned based on  category or item.
- **Document 
 Weight** - Freight carriers such as UPS and FedEx most commonly use  this method. For a given weight range, a specific charge will be applied.
- **Total 
 Document Value** - This is a type of “Flat Rate” shipping. This method  allows you to charge for shipping based on the value of the customer’s  order



**What if multiple types of freight rates are applicable  to items on my sales order?**


When multiple rate definitions are present, the system determines  the appropriate definition to use by calculating the freight separately  for each rate type. The system will then display the highest freight rate  for the sales document.


**Pack Separately**


Large items are often packaged in a separate box. If any  line items are marked “Pack Separately” on the **Item**  profile - **Sales** tab, the item  requires a separate box and the system calculates freight separately for  that item. Each unit of a “Pack separately” item is calculated as if it  is a completely separate order.  After  the highest rate is derived for each package, they are added together  to derive the shipping charge.


For example, a customer purchases a Monitor, a keyboard,  and a mouse on a sales order. The Monitor is marked “Pack Separately”  and the keyboard and mouse are not. The monitor is in one box and the  freight is calculated separately. The keyboard and mouse are in another  box, and the freight is calculated using only these two items.


You can view an estimation of the freight charges by using  the **Everest Freight Estimator**  utility (path: From the Sales document, select **Options**  > **Utility** > **Freight 
 Estimator**).
: ![]({{site.mi_baseurl}}/img/lens.gif)[Rates]({{site.sc_chm}}/options/everest-freight-estimator/rates/freight_rate_ee.html)


{:.see_also}
See also
: [The Item  Profile - Sales]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/the_item_profile_-_sales_tab.html)
: [Item Freight  Dialog Box]({{site.mi_baseurl}}/create-regular-items-kits-and-assemblies/creating-an-item/item_freight_dialog_box_mi.html)
