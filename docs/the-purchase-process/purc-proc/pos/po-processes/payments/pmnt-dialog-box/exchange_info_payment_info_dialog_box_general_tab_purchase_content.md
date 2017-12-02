---
title: Exchange Info
---
<script type="text/javascript" language="JavaScript1.2" x-save-method="compute-relative" src="{{site.pp_baseurl}}/misc/ehlpdhtm.js"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
**Doc Currency**
: This field displays the vendor’s currency. You cannot  edit this field.


**Exchange Rate**
: This field displays the current rate of exchange  between document currency and the base currency, defined in the **Exchange Rate** profile (path: **File**  > **Setup** > **Accounting**  > **Multi** - **Currency**  > **Exchange** **Rates 
 &gt; Options &gt; Edit &gt; In New Window**).
: You can change this rate if required. Correspondingly,  the **Amount** fields of the Payment  currency, Bank currency and Base currency sections also change.


**Amount**
: This field by default displays the balance payable  on the document. If you edit this amount, the **Amount**  fields of the Bank currency, Payment currency and Base currency sections  get updated automatically, using the existing exchange rates.

**Bank Currency**
: This field displays the currency of the bank account  selected in the **Payment** **Method** field. You cannot edit this field.


**Exchange Rate**
: This field displays the current rate of exchange  between the bank currency and the base currency, defined in the **Exchange** **Rate**  profile (path: **File** > **Setup** > **Accounting**  > **Multi** - **Currency**  > **Exchange** **Rates 
 &gt; Options &gt; Edit &gt; In New Window**). If you change the rate,  the **Amount** field of the Bank currency  section also changes correspondingly.


**Amount**
: This field, by default, displays the balance amount  payable on the document in terms of the bank currency. If the **Amount**  field in the Payment currency or Document currency sections is changed,  this field is automatically updated.

**Pay in**
: Use this field to specify the currency in which  the payment is being made. The vendor currency is displayed by default  in this field.


**Exchange Rate**
: This field displays the current rate of exchange  between payment currency and the base currency, defined in the **Exchange 
 Rate** profile (path: **File**  > **Setup** > **Accounting**  > **Multi** - **Currency**  > **Exchange** **Rates 
 &gt; Options &gt; Edit &gt; In New Window**).
: You can change this rate if required. Correspondingly,  the **Amount** field of the Payment  currency section also changes.


**Amount**
: This field displays the amount in vendor’s or document  currency displayed in the **Amount**  field of the **Document Currency**  section. When you change the payment currency, the exchange rate defined  in **Exchange** **Rate**  (path: **File** > **Setup**  > **Accounting** > **Multi**  - **Currency** > **Exchange****Rates**) profile is used to arrive  at this amount.
: If you edit this amount, the **Amount**  fields of the Bank currency, Base currency and Document currency sections  are updated automatically, using the existing exchange rates.

This field displays the currency in which your accounting records are  maintained. You cannot edit this field.

This field displays the amount of payment in the base currency. You  cannot edit this field. If the **Amount**  field in the Payment currency or Document currency sections is changed,  this field is automatically updated.

# Exchange Info


Click the **Exchange** **Info**  button to view relevant information. The fields displayed when you select  this option is divided into the following sections:

- [Document  Currency](javascript:kadovTextPopup(this)){:id="a2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a2');
//--></script>
- [Bank  Currency](javascript:kadovTextPopup(this)){:id="a1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a1');
//--></script>
- [Pay In](javascript:kadovTextPopup(this)){:id="a4"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a4');
//--></script>
- [Base  Currency](javascript:kadovTextPopup(this)){:id="a3"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a3');
//--></script>
- [Amount](javascript:kadovTextPopup(this)){:id="a6"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovTextPopupInit('a6');
//--></script>



{:.note}
Whether the buy or sell rate is displayed in the **Exchange 
 Rate** fields depends on the setting you make in the **Accounting**  dialog box (path: **File &gt; Setup &gt; 
 Preferences &gt; Defaults &gt; Accounting &gt; Multi Currency &gt; Exchange 
 Rates** tab > **Rate for payments**  field).


{:.see_also}
See also
: [Payment  Reference Details - Payment Dialog Box]({{site.pp_baseurl}}/purc-proc/pos/po-processes/payments/pmnt-dialog-box/payment_reference_details.html)
