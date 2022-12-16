<template>
  <div id="app">
    <img src="./assets/logounri.png" height="75" width="300">,
    <web-toolbar>
      <web-home>
        <web-login></web-login>
      </web-home>
    </web-toolbar>

     <router-view/>

    <web-footer></web-footer>
  </div>
</template>

<script>
  import WebFooter from './components/WebFooter.vue'
  import WebToolbar from './components/WebToolbar.vue'
  import WebLogin from './components/WebLogin.vue'
  import WebHome from './components/WebHome.vue'


  export default{
    
    name:'App', 
    components:{WebToolbar, WebHome,WebLogin, WebFooter}   
  }
</script>

<style>

</style>
