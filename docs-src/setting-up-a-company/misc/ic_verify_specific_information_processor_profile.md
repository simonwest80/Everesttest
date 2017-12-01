---
title: ICVerify Specific Information
---

# ICVerify Specific Information


The following fields must be specified only if the payment service selected  is ICVerify.


**License Type**
: This field specifies the number of users that can  use the service simultaneously. The following options are available:

- **Single-user**  - Only one user can use the service at any given point of time.
- **Multi-user**  - Eight users can use the service simultaneously.



**Business Type**
: The business type identifies whether the authorization  requests are for retail (i.e., direct sale) or mail order type of sales.
: Selecting the **Mail****Order** option allows you to choose  one of the following at the time of processing the payment:

- The payment  request for a direct sale.
- Funds to be  booked for a later shipment.
- Funds to be  captured based on an earlier approval number.



**Request Directory Name**
: This is the directory path where the ICVerify  request files are located. You must specify a separate directory path  for each type of card.


{:.example}
The path for MasterCard  cannot be the same as the path for Visa.
: The directory path should be the UNC (Universal  Naming Code) path with respect to the **Everest**  application server.


{:.example}
If ICVerify  is installed in the folder ‘MyWorkstation’,  the UNC path for MasterCard  will be \\MyWorkstation\ICVerify\MasterCard.


{:.note}
The request file path must be in the same local area network as the  **Everest** application server.
: ![]({{site.sc_baseurl}}/img/lens.gif) [Credit  Card Processing with ICVerify]({{site.sc_baseurl}}/misc/credit_card_processing_ic_verify.html)


**Use multiple merchant accounts**
: Check this option if you are using the multi-user  version of ICVerify that supports multi-merchant accounts. The bank authorizing  your credit card is referred to as the merchant bank. Multiple merchants  is a term used when a company has more than one location to process/authorize  its credit cards, with each location having a different dial-up account  to the bank for getting approvals.


{:.note}
Additional configuration is required to use  ICVerify for Multiple Merchants. Refer to the “Configuring ICVerify for  Multiple Merchants” section.
: ![]({{site.sc_baseurl}}/img/lens.gif)[Configuring  ICVerify for Multiple Merchants]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/configuring_icverify_for_multiple_merchants_sc.html)


**Sequence**
: If you are sharing the ICVerify payment processing  software with another company or business, the sequence number defined  here identifies transactions and requests originating from your company.  ICVerify provides a summary of transactions originating from each terminal  based on the merchant sequence number.


{:.note}
This sequence number can also be used when  you are setting up a processor for each payment terminal or cash counter  for every card type supported by ICVerify. You will also have to set up  a payment method for each processor.


{:.see_also}
See also
: [**Processor** Profile - **General**  Tab]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/create-a-processor/processor_profile_general_tab.html)
