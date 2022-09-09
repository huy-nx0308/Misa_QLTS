<template>
    <div class="dialog-handle">
        <div class="dialog-add">
            <div class="dialog-header">
                <h3>Thêm tài sản</h3>
                <div class="icon-close"></div>
            </div>
            <div class="dialog-body">
                <div class="dialog-body-row">
                    <div>
                        <div class="row-text"> Mã tài sản
                            <span style="color:red;">*</span>
                        </div>
                        <input type="text" class="input row-input" >

                    </div>
                    <div style="margin-left: 16px; width: calc(100% - 5px);">
                        <div class="row-text"> Tên tài sản
                            <span style="color:red;">*</span>
                        
                        </div>
                        <input type="text" class="input row-input" placeholder="Nhập tên tài sản" style="width: calc(100% - 19px);">

                    </div>
                </div>
                <div class="dialog-body-row">
                    <div>
                        <div class="row-text">Mã bộ phận sử dụng
                            <span style="color:red;">*</span>
                        </div>
                        
                        <div class="combobox" style="display:flex; position: relative;">
                            <input type="text" value=" Chọn mã bộ phận sử dụng" class="input row-input" style >
                            <div class=" icon-down-bold" style="position: absolute; top:17px;right:10px"></div>
                        </div>
                    </div>
                    <div style="margin-left: 16px; width: calc(100% - 5px);">
                        <div class="row-text">Tên bộ phận sử dụng
                        
                        </div>
                        <input type="text" class="input row-input" value disabled style="width: calc(100% - 19px); background-color: #f5f5f5;"></div>
                </div>
                <div class="dialog-body-row">
                    <div>
                        <div class="row-text">Mã loại tài sản
                            <span style="color:red;">*</span>
                        </div>
                        
                        <div class="combobox" style="display:flex; position: relative;">
                            <input type="text" value=" Chọn mã loại tài sản" class="input row-input"  >
                            <div class=" icon-down-bold" style="position: absolute; top:17px;right:10px"></div>
                        </div>
                    </div>
                    <div style="margin-left: 16px; width: calc(100% - 5px);">
                        <div class="row-text">Tên loại tài sản
                        
                        </div>
                        <input type="text" class="input row-input" value disabled style="width: calc(100% - 19px); background-color: #f5f5f5;"></div>
                </div>
                <div class="dialog-body-row">
                    <div>
                        <div class="row-text">Số lượng
                            <span style="color:red;">*</span>
                            
                        </div>
                        <div class="combobox" style="position: relative;">
                            <input type="text" class="input "  style="text-align: right; padding-right:44px;" value="0" >
                            
                                <div class="icon-up-bold" style="position: absolute; top:11px;right: 10px;"></div>
                                <div class="icon-down-bold" style="position: absolute; top:22px; right:10px ;"></div>
                                
                          
                        </div>
                    </div>
                    <div style="margin-left: 16px;">
                        <div class="row-text" >Nguyên Giá
                            <span style="color:red;">*</span>
                        </div>
                        <input type="text" class="input row-input" style="text-align: right; padding-right: 10px;"  value="0" >
                    </div>
                    <div style="margin-left: 16px; width: calc(100% - 139px);">
                        <div class="row-text">Số năm sử dụng
                            <span style="color:red;">*</span>
                        </div>
                        <input type="text" class="input row-input" style="text-align: right; padding-right: 10px;width: calc(100% - 26px) "  value="0" >
                        
                    </div>
                </div>
                <div class="dialog-body-row">
                    <div>
                        <div class="row-text">Tỷ lệ hao mòn(%)
                            <span style="color:red;">*</span>
                            
                        </div>
                        <div class="combobox" style="position: relative;">
                            <input type="text" class="input "  style="text-align: right; padding-right:44px;" value="0" >
                            
                                <div class="icon-up-bold" style="position: absolute; top:11px;right: 10px;"></div>
                                <div class="icon-down-bold" style="position: absolute; top:22px; right:10px ;"></div>
                                
                          
                        </div>
                    </div>
                    <div style="margin-left: 16px;">
                        <div class="row-text" >Giá trị hao mòn năm
                            <span style="color:red;">*</span>
                        </div>
                        <input type="text" class="input row-input" style="text-align: right; padding-right: 10px;"  value="0" >
                    </div>
                    <div style="margin-left: 16px; width: calc(100% - 139px);">
                        <div class="row-text">Năm theo dõi
                            
                        </div>
                        <input type="text" class="input row-input" style="text-align: right; padding-right: 10px;width: calc(100% - 26px); background-color: #f5f5f5;"  value="2021" >
                        
                    </div>
                </div>
                <div class="dialog-body-row" style="margin-bottom: 25px;0">
                    
                      <div>
                        <div class="row-text">Ngày mua
                            <span style="color:red;">*</span>
                        </div>
                        
                        <div class="combobox" style="display:flex; position: relative;">
                            <input type="text"  class="input row-input"  >
                            <div class=" icon-calendar" style="position: absolute; top:12px;right:10px"></div>
                        </div>
                    </div>
                    <div style="margin-left: 16px;">
                        <div class="row-text">Ngày bắt đầu sử dụng
                            <span style="color:red;">*</span>
                        </div>
                        
                        <div class="combobox" style="display:flex; position: relative; ">
                            <input type="text"  class="input row-input" style="padding-right:10px">
                            <div class=" icon-calendar" style="position: absolute; top:12px;right:10px"></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="dialog-footer">
                <button class="btn btn-cancel" >Hủy</button>
                <button class="btn btn-save" style="margin: 0 15px">Lưu</button>
            </div>
        </div>
    </div>
       
</template>