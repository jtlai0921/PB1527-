$(function () {
    //�I�s����hide�禡���ê���
    $('.subTreeList').hide();
    //�j�w�����I���ƥ�
    $('.TreeIcon').click(function () {
        //�إ�$this�ܼơA�ñNĲ�o�ƥ󪺪���ϥ�$this�ܼ��x�s
        var $this = $(this);
        //�I�s����toggleClass�禡�A�P�_���󦳵L'TreeIcon_open'��class�ݩ�
        //�Y���󦳸��ݩʡA�N��class�ݩʲ����A�۷��removeClass��k
        //�Y����L���ݩʡA�h������s�Wclass�ݩʡA�۷��addClass��k
        $this.toggleClass('TreeIcon_open');
        //�w��Ӫ���U��ul�I�sslideToggle��k�A�Y�bslideToggle��[�Jfunction
        //�h��function��callback
        $this.nextAll('ul').slideToggle(100, function (e) {
            //�Y����i�z�L.TreeIcon_open��ܡA�h�ХܸӪ���]�tTreeIcon_open��class�ݩ�
            if ($this.is('.TreeIcon_open')) {
                //�b���󤤷s�W-����r
				$this.text('-');
			}
            else {
                //�b���󤤷s�W+����r
				$this.text('+');
			}
		})
	});
});