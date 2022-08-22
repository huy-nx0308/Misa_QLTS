!<template>
    <div class="navbar">
        <div class="nav-header">
            <div class="nav-header-item">
                <div class="icon-logo nav-header-item-logo "></div>
                <div class="nav-header-item-text">MISA QLTS</div>
            </div>
        </div>
        <div class="nav-content">
            <div class="nav-content-item">
                <div class="nav-content-icon icon-overview"></div>
                <div class="nav-content-text">Tổng quan</div>
            </div>
            <div class="nav-content-item">
                <div class="nav-content-icon icon-asset"></div>
                <div class="nav-content-text">Tài sản</div>
                <div class="nav-icon-down icon-drop_down"></div>
                
            </div>
            <div class="nav-content-item">
                <div class="nav-content-icon icon-asset1"></div>
                <div class="nav-content-text">Tài sản HT-ĐB</div>
                <div class="nav-icon-down icon-drop_down"></div>
            </div>
            <div class="nav-content-item">
                <div class="nav-content-icon icon-tool"></div>
                <div class="nav-content-text">Công cụ dụng cụ</div>
                <div class="nav-icon-down icon-drop_down"></div>
            </div>
            <div class="nav-content-item">
                <div class="nav-content-icon icon-category"></div>
                <div class="nav-content-text">Danh mục</div>
            </div>
            <div class="nav-content-item">
                <div class="nav-content-icon icon-search"></div>
                <div class="nav-content-text">Tra cứu</div>
                <div class="nav-icon-down icon-drop_down"></div>
            </div>
            <div class="nav-content-item">
                <div class="nav-content-icon icon-report"></div>
                <div class="nav-content-text">Báo cáo</div>
                <div class="nav-icon-down icon-drop_down"></div>
            </div>

        </div>
        <div class="nav-footer">
            <div class="icon-resize-nav" @click="pop_up"></div>
        </div>
    </div>
</template>
<script>
export default {
    name: "TheNavbar",
    methods: {
        pop_up (){
            alert(1);
        }
    },
   
    
}

    



</script>