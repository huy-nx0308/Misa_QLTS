<template>
<div class="container">
  <Navbar/>
  <PageRight/>
   
  
</div>
  <Dialog/>
</template>

<script>

import Navbar from './components/page-left/TheNavbar.vue'
import PageRight from './components/page-right/ThePageRight.vue'
import Dialog from './components/page-right/TheDialog.vue'

export default {
  name: 'App',
  components: {
    Navbar,PageRight,Dialog
  }
}
</script>

<style>
@import url(./css/main.css);
</style>
