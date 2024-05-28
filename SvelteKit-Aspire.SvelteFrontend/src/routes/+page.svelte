<script lang="ts">
	import HelloWorld from '$lib/components/HelloWorld.svelte';
	import TheWelcome from '$lib/components/TheWelcome.svelte';
  import Icon from '$lib/assets/logo.svg';
</script>

<header>
	<img alt="Svelte logo" class="logo" src={Icon} width="125" height="125" />

	<div class="wrapper">
		<HelloWorld msg="Svelte Weather!" />
	</div>
</header>

<main>
	<TheWelcome />
</main>

<style>
	header {
		line-height: 1.5;
	}

	.logo {
		display: block;
		margin: 0 auto 2rem;
	}

	@media (min-width: 1024px) {
		header {
			display: flex;
			place-items: center;
			padding-right: calc(var(--section-gap) / 2);
		}

		.logo {
			margin: 0 2rem 0 0;
		}

		header .wrapper {
			display: flex;
			place-items: flex-start;
			flex-wrap: wrap;
		}
	}
</style>
