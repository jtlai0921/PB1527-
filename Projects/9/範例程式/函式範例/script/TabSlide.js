$(function(){
	var _showTabInd = 0;
	$(".myTab").each(function(index, element) {
        var $tab = $(this);
		//�j�w����click�ƥ�
        $('.tab_header a', $tab).click(function (e) {
            //�إ�$this�ܼơA�ñNĲ�o�ƥ󪺪���ϥ�$this�ܼ��x�s
            var $this = $(this),
                //�إ�_showTab�ܼơA�éI�s����attr��k���o��href�ݩ�
				_showTab = $($this.attr('href')),
                //�إ�_oldTabLink�ܼơA�x�s����
				_oldTabLink = $('.tab_header a.active'),
                //�إ�_oldTab�ܼơA�éI�s����attr��k���o��href�ݩ�
				_oldTab = $(_oldTabLink.attr('href'));
            //�I�s_oldTabLink��removeClass��k�A����class�ݩ�
            _oldTabLink.removeClass('active');
            //�N_oldTab������ܡA�éI�sslideToggle��k�A�ϥΤU�ƪ��覡���
            _oldTab.show().slideToggle();
            //��������class�ݩ�
            $this.addClass('active');
            //�N_showTab�������áA�éI�sslideToggle��k�A�ϥΤW�ƪ��覡����
			_showTab.hide().slideToggle();
			
            //�z�LpreventDefault�ƥ�A�����o�ͦۦ��q�{���ƥ�
			e.preventDefault();
			return false;
		});
	    //�I�s����hide��k�A���ê���
        $('.tab_content', $tab).hide();
	    //�I�s����_showTabInd��click�ƥ�
		$('.tab_header a', $tab).eq(_showTabInd).click();
		
    });
});