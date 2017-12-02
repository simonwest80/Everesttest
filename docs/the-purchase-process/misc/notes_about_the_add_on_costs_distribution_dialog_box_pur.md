---
title: Notes about the Add-on Costs Distribution Dialog Box
---

# Notes about the Add-on Costs Distribution Dialog Box


The Add-on Cost Distribution dialog box of a backordered purchase order  displays in View mode and you cannot edit the fields.


The Add-on Costs Distribution dialog box for a purchase invoice changes  depending on whether the document FOB Type is set to Origin or Destination:

- **FOB 
 Origin** – If you received quantity on the purchase invoice, the  Received on Invoice section displays and the Invoiced section disappears.  All values pertain to the Received on Invoice quantity. If you did not  receive any quantity on the invoice, you cannot allocate add-on costs  and so you cannot open the Add-on Cost Distribution dialog box. In addition,  the Add-on Cost, Add-on Amount columns do not display in the document’s  item details grid.
- **FOB 
 Destination** – If you received quantity on the purchase invoice,  both the Received on Invoice and Invoiced sections display. Otherwise,  only the Invoiced section displays.



When you save a purchase document, the system checks the cost and the  quantity used to distribute add-on costs against the cost and quantity  shown in the document. If a difference exists, for example if you changed  the cost or quantity of a line item after you distributed the add-on costs,  the system alerts you to the discrepancy and asks if you want to redistribute  the add-on costs. You have the following options:

- **Yes**,  to open the Add-on Costs Distribution dialog box.
- **No**,  to save the document without adjusting the add-on costs (which leaves  incorrect data).
- **Cancel**,  to return to the document without saving it.



{:.see_also}
See also
: [The  Add-on Costs Distribution Dialog Box]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/utils/addon-costs-distr/the_freight_distribution_dialog_box.html)
