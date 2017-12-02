---
title: Convert Lease Quotes and Orders
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.sp_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Convert Lease Quotes and Orders


When a sales quote with a lease plan attached is converted to an order  and then to an invoice, the details of the plan attached are copied to  the sales order or invoice.


![]({{site.sp_baseurl}}/img/lens.gif) [Create a Lease Quote]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/lease-plans/create-lrq/creating_a_lease_quote.html)


A lease quote is initially in the name of the customer. When the customer  enters into a lease agreement with a financier, the sales order and invoice  are billed to the lessor, but the items are shipped to the lessee.


{:.steps}
The following steps are involved in leasing  an item:

- Create a lease  quote in the customer's (i.e. [Lessee's](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/lessee.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>)  name.
- Convert the  lease quote to a sales order.
- Change the  billing address of the customer in the order or invoice to the [lessor's](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/lessor.html');){:id="A2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A2');
//--></script>  address and ensure that the shipping address belongs to the lessee.
- Create the  sales invoice and ship the items to the lessee.



{:.see_also}
See also
: [Converting  Rental Quotes and Orders]({{site.sp_baseurl}}/sales-docs/sqs/sq-proc/lease-plans/cnvrt-lrq-to-so/converting_rental_quotes_and_orders.html)
