<template>
    <div class="page-right" >
        
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
    }
}
</script>
