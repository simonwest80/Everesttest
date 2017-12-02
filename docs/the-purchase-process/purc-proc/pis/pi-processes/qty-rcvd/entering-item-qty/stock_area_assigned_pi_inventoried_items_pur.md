---
title: Stock Area Assigned - Purchase Invoice
---

# Stock Area Assigned - Purchase Invoice


Inventoried items are assigned to an "In" type of stock area  when they are received on a purchase invoice. The default stock area is  determined by the following rules:

- If a default stock  area for a purchase invoice is specified in the **Workstation 
 Settings** dialog box (path: **File 
 &gt; Setup &gt; Preferences &gt; Workstation Settings &gt; Stock Areas 
 &gt; For Purchase** tab > **Transfer 
 Inventory to** section > **Purchase 
 Invoice** field), items are assigned to this stock area.


- If this stock  area is not defined, **Everest** assigns  the items to the stock area specified in the **Location**  profile (path: **File &gt; Setup &gt; Accounting 
 &gt; Location/Sub-Location &gt; Options &gt; Edit &gt; In New Window &gt; 
 Stock Transfer &gt; Purchase Document** tab > **Select 
 Stock Area to transfer inventoried items into when creating** section  > **Purchase Invoice**) of the  login location.
- If the stock area is not defined for the login  location, the items are assigned to the stock area defined for purchase  invoices in the default location. The default location is specified in  the **Accounting** dialog box (path:  **File &gt; Setup &gt; Preferences &gt; 
 Defaults &gt; Accounting &gt; Miscellaneous** tab > **Default 
 Location** field).


{:.note}
The **Stock 
 Area** field displays in the status bar when you need to select a  stock area. Select a stock area and press the **Enter**  key or **ESC** key to exit this field  and continue.



{:.see_also}
See also
: [Enter  Quantities Received - Non-Serialized Items]({{site.pp_baseurl}}/purc-proc/pis/pi-processes/qty-rcvd/entering-item-qty/entering_quantities_received_non_serialized_items_pur_invoice_pur.html)
