---
title: Sale Details
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.sp_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Sale Details


This option is used in [sale](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/sale_1.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>  transactions where the items are delivered immediately after payment.


{:.example}
For Point of Sale transactions in retail stores, or  at ticket counters for travel.


When you process a new payment, the processed amount is charged against  the cardholder's account, and the amount is [captured](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/capture_1.html');){:id="A2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A2');
//--></script>.  The transaction is marked through the financial network for immediate  [settlement](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/settlement_1.html');){:id="A3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A3');
//--></script>.


{:.note}
You can select only one of the options: sale, pre-authorize  or use prior authorization while processing a payment.


{:.see_also}
See also
: [Back  End Processes and Accounting Entries]({{site.sp_baseurl}}/misc/back_end_processes_and_accounting_entries_new_payments.html)
: [Card Verification  Details]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify/card_verification_details.html)
