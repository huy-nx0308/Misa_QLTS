<template>
<div class="container">
  <Navbar/>
  <PageRight/>
   
  
</div>
  
</template>

<script>

import Navbar from './components/page-left/TheNavbar.vue'
import PageRight from './components/page-right/ThePageRight.vue'

export default {
  name: 'App',
  components: {
    Navbar,PageRight
  }
}
</script>

<style>
@import url(./css/main.css);
</style>
