---
title: Shipping Details
---

# Shipping Details


**Ship Via**
: The delivery method defined in the **Ship 
 Via** field of the document profile is displayed, by default, in  this field. You can change the delivery method from the document profile  or the **Rate Shop** window. You must  identify the shipping agent/carrier in the **Delivery 
 Method** profile.


**Rate Shop**
: Click the ![]({{site.pp_baseurl}}/img/pur_rate_shop.gif) button to change the  delivery method in this field. You will see the **Rate****Shop** **Browser**  that displays a list of all delivery methods and the corresponding rates.  To change the delivery method, select a record from the **Rate****Shop** **Browser**  and click **OK**.
: If you change the delivery method in this field,  and update the document with the freight charges, the **Ship****Via** field in the document profile  also reflects the changes made.


**Declared Value**
: The declared value is the total amount of all the  items (including non-inventoried items) on the document. This value is  used for computation of insurance. You can edit the declared value.


**Number of Packages**
: Specify the number of packages in which the items  are shipped. Package based freight related charges (such as COD fee and  residential address charges) if any, are computed based on the number  of packages.
: ![]({{site.pp_baseurl}}/img/lens.gif) [The  Carrier Profile - Additional Rates]({{site.sc_chm}}/misc/delivery_method_profile_rate_tab.html)


**Weight**


By default, the weight of all the items on the document  duly converted to the weight measure (such as Kg/Lb) of the country pertaining  to the document's location/sub-location is displayed. The weight of the  shipment determines the transportation cost.


**Consider Pack Separately Flag**


Select this check box if the pack separately setting  in the **Item** profile must be considered  while computing the number of packages.


{:.example}
You purchase three monitors, each unit weighing  10 lbs. You are charged freight at $3 per lb or $50 per package of the  item, whichever is more.


**Case 1:**  If you do not select the "Pack Separately" check box:


Freight for 3 monitors = $3 x (3x10 lbs) =  $90


Minimum freight per package = $50


Thus, freight for the monitors is $90.00


**Case 2:**  If you select the "Pack Separately" check box:


Freight for 3 monitors = $3 x (3x10 lbs) =  $90


Minimum freight per package = $50


Thus, freight for the three monitors is $150  (3x $50)


This check box is enabled and automatically selected  if you select the **Pack Separately**  check box in the **Item** profile  (path: **Inventory &gt; Items &gt; Options 
 &gt; Edit &gt; in New Window &gt; Sales** tab) for any item contained  in the purchase document.


**C.O.D**


Select this check box if the **COD**  (Cash on Delivery) fee has to be added to the estimated freight cost.  This check box is automatically selected if **COD**  is selected (path: **File &gt; Setup &gt; 
 Accounting &gt; Payment Terms &gt; Options &gt; Edit &gt; In New Window 
 &gt; Payment Term Type** field) for the payment term associated with  the document. You can modify this field.
: ![]({{site.pp_baseurl}}/img/lens.gif) [Payment  Terms]({{site.sc_chm}}/options/payment-information/payment-terms/payment_terms.html)


**Insured**


Select this check box to compute insurance charges  on the insured shipment.


**Residential**


This check box is checked by default if you select  the **Residential** check box for  the address displayed in the **Shipment 
 Destination** field. You can modify this field. The residential charges  are computed only if this check box is selected.


{:.see_also}
See also
: [Everest  Freight Estimator dialog box]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/utils/freight-est/everest_freight_estimator_dialog_box_purchases.html)
