(function () {
    $(function () {
        $(".oneMscomFooterV3 a[href='http://emea.microsoftstore.com/es/es-ES?WT.mc_id=MSCOM_HP_ES_Nav_BuyShopNow']").each(function () {
            var href = $(this).attr("href");
            href = href.substr(0, href.indexOf('?'));
            $(this).attr("href", href + "?WT.mc_id=SMCMSCOM_ESES_NAV_BUYALL");
        });
     
    });
})();
