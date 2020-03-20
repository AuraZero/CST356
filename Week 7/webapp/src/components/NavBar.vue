<template>
    <div class="links">
        <span v-on:click='goToHome' class="singleLink">Home</span>
        <span v-on:click='goToInstructors' class="singleLink">Instructors</span>
        <span v-on:click='goToStudents' class="singleLink">Students</span>
    </div>
</template>

<script>
  export default {
    name: 'NavBar',
    methods: {
      goToHome: function() {
        this.$router.push({ path: 'home' })
      },
      goToInstructors: function() {
        this.$router.push({ path: 'Instructors' })
      },
      goToStudents: function() {
        this.$router.push({ path: 'Students' })
      }
    }
  }
</script>

<style scoped>
  span {
      font-family: monospace;
      font-weight: bold;
      font-size: 14pt;
      cursor: pointer;
      padding-right: 20px;
      background-color: white;
      text-align: center;
  }

  .links {
      background-color: lightgray;
      margin-top: 20px;
      padding: 10px;
  }
</style>