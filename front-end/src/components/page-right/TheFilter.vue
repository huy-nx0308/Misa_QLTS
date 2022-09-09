!<template>
    <div class="filter">
        <div class="filter-left">
             <!--Tìm kiếm tài sản-->
            <div class="input-search">
                <div class="icon-search-filter input-search-icon"></div>
                <input type="text" placeholder="Tìm kiếm tài sản" class="input input-search-text">
            </div>
            <!--loại tài sản-->
            <div class="combobox asset-type" style="margin: 0 10px;">
                <div class="asset-type-container">
                    <div class="cb-icon-left icon-type-asset"></div>
                    <input type="text" value="Loại tài sản" class="input input-asset-type">
                    <div class="cb-icon-right icon-down-bold"></div>
                </div>
                <div class="combobox-asset-option"></div>
            </div>
             <!--bộ phận sử dụng-->
            <div class="combobox used-part">
                <div class="used-part-container">
                    <div class="cb-icon-left icon-type-asset"></div>
                    <input type="text" value="Bộ phận sử dụng" class="input input-used-part">
                    <div class="cb-icon-right icon-down-bold"></div>
                </div>
                <div class="used-part-option"></div>
            </div>
        </div>
        <div class="filter-right">
            <button class="btn btn-add" @click="btnShowDialog">
                <div class="btn-add-container">
                    <div class="icon-plus"></div>
                    <div class="btn-add-text">Thêm tài sản</div>
                </div>
              
            </button>
            <button class="btn btn-export">
              
                <div class="icon-export"></div>
            </button>
            <button class="btn btn-delete">
                <div class="icon-delete"></div>
            </button>
        </div>
        <Dialog v-if="isShowDialog" />
    </div>
    
</template>
<script>
import Dialog from './TheDialog.vue'
export default {
    
    name : "TheFilter",
    components: {
        Dialog
    },
    data(){
        return{
            isShowDialog: false,
        };
    },

    methods:{
        //bấm add show dialog
        btnShowDialog(){
            try {
                this.isShowDialog = true;
                
                
            } catch (error) {
                console.log(error);
            }
        }
    },

}
</script>