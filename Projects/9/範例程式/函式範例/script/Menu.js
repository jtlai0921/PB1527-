$(function () {
    var _showTabInd = 0;
    //�z�Leach��k�A�W�d�C�Ӫ���Ҷ��j�w���ʧ@
	$(".MenuBar").each(function(index, element) {
        var $menu = $(this);
	    //hover�禡�]�t�ƹ����Jmouseover��mouseout�ƥ�
        //�Ĥ@��function������mouseover�ƥ�
        $("li:not(ul.SubMenu li)", $menu).hover(function (e) {
            //�إ�$this�ܼơA�ñNĲ�o�ƥ󪺪���ϥ�$this�ܼ��x�s
		    var $this = $(this),
                //�إ�_subMenu�ܼơA�z�Lfind�禡�j�M$this�ܼƤ���'ul.SubMenu'����
                //�P�ɱN�Ӫ���ϥ�_subMenu�ܼ��x�s
			 	_subMenu = $this.find('ul.SubMenu');
            //�I�s_subMenu����slideToggle�禡�A�Y�Ӫ������îɡA�ϥΤU�ƪ��覡���
            //slideToggle�禡���i�ǤJ�@�Ʀr����speed�ѼơA����U�ƪ��t�סC
		    _subMenu.slideToggle(50);
        //�ĤG��function������mouseout�ƥ�
        }, function (e) {
            //�إ�$this�ܼơA�ñNĲ�o�ƥ󪺪���ϥ�$this�ܼ��x�s
            var $this = $(this),
                //�إ�_subMenu�ܼơA�z�Lfind�禡�j�M$this�ܼƤ���'ul.SubMenu'����
                //�P�ɱN�Ӫ���ϥ�_subMenu�ܼ��x�s
			 	_subMenu = $this.find('ul.SubMenu');
            //�I�s_subMenu����slideToggle�禡�A�Y�Ӫ�����ܮɡA�ϥΤW�ƪ��覡�Y�p
            //slideToggle�禡���i�ǤJ�@�Ʀr����speed�ѼơA����W�ƪ��t�סC
			_subMenu.slideToggle(50);
		});
		//����hover�禡��A�I�s����hide�禡���ê���A�������󪺪�l��
		$('.SubMenu', $menu).hide();
		
    });
});