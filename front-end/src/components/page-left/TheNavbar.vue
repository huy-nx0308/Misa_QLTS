!<template>
    <div :class="{'set-width-navbar':isShowNavbar}" class="navbar">
        <div class="nav-header">
            <div class="nav-header-item">
                <div class="icon-logo nav-header-item-logo "></div>
                <div class="nav-header-item-text"  v-show="!isShowNavbar">MISA QLTS</div>
            </div>
        </div>
        <div class="nav-content">
            <div class="nav-content-item">
                <div class="nav-content-icon icon-overview"></div>
                <div class="nav-content-text"  v-show="!isShowNavbar">Tổng quan</div>
            </div>
            <div  class="nav-content-item"  style="background-color:#1aa4c8">
                <div  class=" nav-content-icon icon-asset icon-asset-clicked" ></div>
                <div class="nav-content-text"  v-show="!isShowNavbar" >Tài sản</div>
                <div class="nav-icon-down icon-drop_down"  v-show="!isShowNavbar"></div>
                
            </div>
            <div class="nav-content-item">
                <div class="nav-content-icon icon-asset1"></div>
                <div class="nav-content-text"  v-show="!isShowNavbar">Tài sản HT-ĐB</div>
                <div class="nav-icon-down icon-drop_down"  v-show="!isShowNavbar"></div>
            </div> 
            <div class="nav-content-item">
                <div class="nav-content-icon icon-tool"></div>
                <div class="nav-content-text"  v-show="!isShowNavbar">Công cụ dụng cụ</div>
                <div class="nav-icon-down icon-drop_down"  v-show="!isShowNavbar"></div>
            </div>
            <div class="nav-content-item">
                <div class="nav-content-icon icon-category"></div>
                <div class="nav-content-text"  v-show="!isShowNavbar">Danh mục</div>
            </div>
            <div class="nav-content-item">
                <div class="nav-content-icon icon-search"></div>
                <div class="nav-content-text"  v-show="!isShowNavbar">Tra cứu</div>
                <div class="nav-icon-down icon-drop_down"  v-show="!isShowNavbar"></div>
            </div>
            <div class="nav-content-item">
                <div class="nav-content-icon icon-report"></div>
                <div class="nav-content-text"  v-show="!isShowNavbar">Báo cáo</div>
                <div class="nav-icon-down icon-drop_down"  v-show="!isShowNavbar"></div>
            </div>

        </div>
        <div class="nav-footer">
            <div class="icon-resize-nav" @click="resizeNavbar()" v-show="!isShowNavbar"></div>
        </div>
    </div>
</template>
<script>

export default {
    name: "TheNavbar",
    data(){
        return{
            isShowNavbar: false,
            isActive: false,

        };
    },
   
    methods: {
         /*  
            hàm xử lý co Navbar
        */ 
       resizeNavbar(){
            try {
                this.isShowNavbar = true;
                this.emitter.emit("set-width-page-right");
                
            } catch (error) {
                console.log(error);
            }
       },

       /*
       hàm xử lý khi được icon tài sản được click vào
       */
       isClicked(){
            try {
                this.isActive = true;
                
            } catch (error) {
                console.log(error);
            }
       }

    }
   
    
}

    



</script>