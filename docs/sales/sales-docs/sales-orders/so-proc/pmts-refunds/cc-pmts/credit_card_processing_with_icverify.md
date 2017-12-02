---
title: Credit Card Processing with IC Verify
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.sp_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Credit Card Processing with IC Verify


When the payment method is attached  to a processor with ICVerify as the service selected, you can process  the following types of transactions and requests:

- [Address verification](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/address_verification_1.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>.
- [Sale](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/sale_1.html');){:id="A2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A2');
//--></script>  type of transactions where the payment is authorized and funds transferred  to your bank account in the next settlement period.
- Validation  of the card verification value.
- Pre-authorization  requests for [authorization](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/authorization_1.html');){:id="A3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A3');
//--></script>.
- Pre-authorization  request for [book for later shipment](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/book_for_later_shipment_1.html');){:id="A4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A4');
//--></script>.
- [Prior authorization](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/prior_authorization_1.html');){:id="A5"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A5');
//--></script>  requests for [Force Sale](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/force_sale_1.html');){:id="A6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A6');
//--></script>  to [capture](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/capture_1.html');){:id="A7"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A7');
//--></script>  funds where the authorization has been obtained earlier. The authorizations  include [voice authorizations](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/voice_authorizations.html');){:id="A8"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A8');
//--></script>.
- Prior authorization  requests for [Ship (Prior Booking)](javascript:BSSCPopup('{{site.sp_baseurl}}/misc/ship_prior_booking__1.html');){:id="A9"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A9');
//--></script>  to capture funds where the authorization has been obtained to book for  later shipment.



{:.note}
ICVerify processes payments and refunds with up to two  places of decimal accuracy. Errors might occur in processing if the process  file contains more than two decimal places.


Response Codes


The first character of the response codes received for  ICVerify transactions indicates the transaction status. This could be  any of the following:

- Y  - Approved
- N  - Declined
- P - Approved not  captured
- Q  - Approved for VISA/MC  purchase card
- B - Approved for  VISA/MC business  card
- C  - Approved for VISA/MC  corporate card



The next six digits represent the approval code. Thus,  the response for an approved transaction could be"Y123456Y".


If your processing network is host-based, an additional  eight digits represent the reference number that was returned by your  processing network. In this case, the response could be "Y12345687654321Y".


{:.see_also}
See also
: [Configuration  file for ICVerify]({{site.sc_chm}}/options/payment-information/credit-card-processing/ini-file-for-icverify/configuration_file_for_icverify.html)
: [Credit  Card Processing with Payflow  Pro]({{site.sp_baseurl}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/credit_card_processing_with_payflow_pro.html)
