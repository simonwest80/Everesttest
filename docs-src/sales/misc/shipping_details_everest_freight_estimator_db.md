---
title: Shipping Details
---

# Shipping Details


**Ship Via**
: Select the delivery method by which the items are  to be shipped. The delivery method defined in the **Ship 
 Via** field of the document profile is displayed by default in this  field. The carrier must be identified in the **Delivery 
 Method** profile of the delivery method for the document.
: Click the ![]({{site.sp_baseurl}}/img/sales_rate_shop_button.gif) button if you want to  change the delivery method in this field. You will see the **Rate Shop** browser **** that displays a list of all the delivery methods and the corresponding  rates that have been set up. To change a delivery method, select a record  from the **Rate Shop** browser and  click **OK**.
: If you change the delivery method in this field,  and update the document with the freight charges, the **Ship 
 Via** field in the document profile also reflects the changes made.


**Declared Value**
: The declared value is the total amount of all the  items on the document (excluding taxes, if any) that are included for  freight computation. This value is used for computation of insurance.  The declared value may be edited if required.


**Number of Packages**
: Package based freight related charges (such as COD  fee and residential address charges) if any, are computed based on the  number of packages.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Carrier  Profile - Additional Rates]({{site.sc_chm}}/misc/delivery_method_profile_rate_tab.html)


**Weight**
: By default, the weight of all the items on the document  duly converted to the weight measure (such as Kg/Lb) of the country pertaining  to the document's location/sub-location is displayed. The weight of the  shipment determines the transportation cost.


{:.note}
Freight is computed on an item if you select the **Include in Freight Calculation** option  on the **Item** profile (path: **Item** profile > **Sales**  tab).


**Consider Pack Separately Flag**
: If you check this option, each unit of sales measure  of the line item is packed separately from the other sales unit of the  same line item.


{:.example}
1) Eggs are sold in dozens only. If 10 quantities  of eggs are sold on a sales order, it implies that 10 dozen eggs are sold.

- If **Pack 
 Separately** option is **not**  selected, all 10 dozen will be packed together in one package.
- If **Pack 
 Separately** option is selected, it would mean that each dozen is  packed separately, resulting in 10 packages containing 1 dozen eggs each.



2) If 6 monitors, 6 CPUs and 6 keyboards are  sold, and **Consider Pack Separately Flag**  is selected for monitors only, there would be 7 packages as under:

- Six packages,  one for each monitor, and
- One package  consisting of 6 CPUs and 6 keyboards


{:.note}
This check box is disabled if all the line  items in the document are NOT set to be packed separately. You can enable  it by selecting the **Pack Separately**  check box in the **Item** profile  (path: **Inventory &gt; Items &gt; Item** profile **&gt; Sales** tab).


**C.O.D**
: Select this check box to add the COD (Collect on  Delivery) fee to the estimated freight cost. The COD fee is payable if  the carrier is responsible for collecting the invoice value from the customer.  The **C.O.D**  check box is automatically selected if **COD**  is selected in the [**Payment Term Type** field]({{site.sc_chm}}/options/payment-information/payment-terms/set-up-a-payment-term/payment_terms_profile_general_tab.html) of the payment  term selected in the **Terms** field  of the document profile.
: You can modify this field.


**Insured**
: Select this check box to indicate that the shipment  is insured and compute insurance charges on the document.


**Residential**
: This check box is automatically selected if you  select the **Residential** check box  for the address displayed in the **Shipment 
 Destination** field. The residential charges are computed if this  check box is selected.


{:.see_also}
See also
: [The  Everest Freight Estimator Dialog Box]({{site.sp_baseurl}}/sales-docs/docs-profile/options/utility/freight-est/everest-freight-estimator/the_everest_freight_estimator_dialog_box.html)
