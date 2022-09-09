<template>
    <div :class="{'set-width-page-right': isSetWidth}" class="page-right" >
        
        <Header></Header>
        <div class="page-right-body">
            <Filter></Filter>
            <Content></Content>
         
        </div>
        
        
    </div>
</template>
<script>
import Header from './TheHeader'
import Filter from './TheFilter.vue'
import Content from './TheContent.vue'


export default {
    components:{
        Header, Filter, Content
    },
    data(){
        return{
            isSetWidth: false
        };
    },

    mounted(){
        try {
            //nhận dữ liệu set lại width từ Navbar
            this.emitter.on("set-width-page-right", () => {
                //gán giá trị lại cho page-right
                this.isSetWidth = true
            })
        } catch (error) {
            console.log(error);
        }
    }

    

   
}
</script>
<style>
@import url(../../css/main.css);
</style>
